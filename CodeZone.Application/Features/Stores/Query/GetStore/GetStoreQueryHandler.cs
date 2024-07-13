using AutoMapper;
using CodeZone.Application.Contracts.Persistence;
using CodeZone.Application.Exceptions;
using MediatR;

namespace CodeZone.Application.Features.Stores.Query.GetStore
{
    public class GetStoreQueryHandler : IRequestHandler<GetStoreQuery, StoreDetailesDto>
    {
        private readonly IStoreRepository _repository;
        private readonly IMapper _mapper;

        public GetStoreQueryHandler(IStoreRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<StoreDetailesDto> Handle(GetStoreQuery request, CancellationToken cancellationToken)
        {
            var store = await _repository.GetStoreByIdWithItems(request.Id);
            if (store == null)
                throw new NotFoundException("Not Found this store");

            return _mapper.Map<StoreDetailesDto>(store);
        }
    }
}
