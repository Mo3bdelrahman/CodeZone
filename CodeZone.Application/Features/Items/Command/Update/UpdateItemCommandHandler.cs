using AutoMapper;
using CodeZone.Application.Contracts.Infrastructure;
using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Items.Command.Update
{
    public class UpdateItemCommandHandler : IRequestHandler<UpdateItemCommand, bool>
    {
        private readonly IRepository<Item> _repository;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;

        public UpdateItemCommandHandler(IRepository<Item> repository, IMapper mapper, IImageService imageService)
        {
            _repository = repository;
            _mapper = mapper;
            _imageService = imageService;
        }

        public async Task<bool> Handle(UpdateItemCommand request, CancellationToken cancellationToken)
        {
            Item item = _mapper.Map<Item>(request);
            var res = await _repository.Update(item);
            if (!res)
                throw new Exceptions.BadRequestException("Error in update Item");

            if (request.Image != null)
            {
                string url = await _imageService.SaveImage(request.Image, item);
                item.Image = url;
                await _repository.Update(item);
            }

            return res;
        }
    }
}
