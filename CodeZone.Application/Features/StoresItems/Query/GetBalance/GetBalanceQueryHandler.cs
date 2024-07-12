
using CodeZone.Application.Contracts.Persistence;
using MediatR;


namespace CodeZone.Application.Features.StoresItems.Query.GetBalance
{
    public class GetBalanceQueryHandler : IRequestHandler<GetBalanceQuery, int>
    {
        private readonly IStoreItemRepository _repository;

        public GetBalanceQueryHandler(IStoreItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(GetBalanceQuery request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetStoreItem(request.StoreId,request.ItemId);
            if (entity == null)
                throw new Exceptions.NotFoundException("Not Found this item");
            return entity.Quantity;
        }
    }
}
