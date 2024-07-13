using AutoMapper;
using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;
using MediatR;

namespace CodeZone.Application.Features.Items.Query.GetAllItems
{
    public class GetAllItemsQueryHandler : IRequestHandler<GetAllItemsQuery, IReadOnlyList<ItemDto>>
    {
        private readonly IRepository<Item> _repository;
        private readonly IMapper _mapper;

        public GetAllItemsQueryHandler(IRepository<Item> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<ItemDto>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        {
            var Items = await _repository.GetAll();
            var itemsDtos = _mapper.Map<IReadOnlyList<ItemDto>>(Items);
            return itemsDtos;
        }
    }
}
