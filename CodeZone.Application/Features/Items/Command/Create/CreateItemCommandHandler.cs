using AutoMapper;
using CodeZone.Application.Contracts.Infrastructure;
using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;
using MediatR;

namespace CodeZone.Application.Features.Items.Command.Create
{
    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, int>
    {
        private readonly IRepository<Item> _repository;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;

        public CreateItemCommandHandler(IRepository<Item> repository, IMapper mapper, IImageService imageService)
        {
            _repository = repository;
            _mapper = mapper;
            _imageService = imageService;
        }

        public async Task<int> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            Item item = _mapper.Map<Item>(request);
            var res = await _repository.Add(item);
            if (!res)
                throw new Exceptions.BadRequestException("Error in create Item");

            if (request.Image != null)
            {
                string url = await _imageService.SaveImage(request.Image, item);
                item.Image = url;
                await _repository.Update(item);
            }

            return item.Id;
        }
    }
}
