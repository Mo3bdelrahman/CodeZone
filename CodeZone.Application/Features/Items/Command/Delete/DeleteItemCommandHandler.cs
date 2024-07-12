using CodeZone.Application.Contracts.Infrastructure;
using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Items.Command.Delete
{
    public class DeleteItemCommandHandler : IRequestHandler<DeleteItemCommand, bool>
    {
        private readonly IRepository<Item> _repository;
        private readonly IImageService _imageService;

        public DeleteItemCommandHandler(IRepository<Item> repository, IImageService imageService)
        {
            _repository = repository;
            _imageService = imageService;
        }

        public async Task<bool> Handle(DeleteItemCommand request, CancellationToken cancellationToken)
        {
            var item = await _repository.GetById(request.Id);
            if (item == null)
                throw new Exceptions.NotFoundException("Not Found this Item");

            var res = await _repository.Delete(item);
            if (!res)
                throw new Exceptions.BadRequestException("Error While Delete Item");

             _imageService.DeleteImage(item);

            return res;
        }
    }
}
