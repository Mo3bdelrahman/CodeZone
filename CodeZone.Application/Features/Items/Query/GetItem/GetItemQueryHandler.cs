using AutoMapper;
using CodeZone.Application.Contracts.Persistence;
using CodeZone.Application.Exceptions;
using CodeZone.Domain.Entities;
using MediatR;

namespace CodeZone.Application.Features.Items.Query.GetItem
{
    public class GetItemQueryHandler : IRequestHandler<GetItemQuery, ItemDto>
    {
        private readonly IRepository<Item> _repository;
        private readonly IMapper _mapper;

        public GetItemQueryHandler(IRepository<Item> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ItemDto> Handle(GetItemQuery request, CancellationToken cancellationToken)
        {
            var item = await _repository.GetById(request.Id);
            if (item == null)
                throw new NotFoundException("Not Found this Item");

            return _mapper.Map<ItemDto>(item);
        }
    }
}
