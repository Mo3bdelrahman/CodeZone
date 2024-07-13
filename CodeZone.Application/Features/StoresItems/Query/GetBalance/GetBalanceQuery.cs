using MediatR;

namespace CodeZone.Application.Features.StoresItems.Query.GetBalance
{
    public class GetBalanceQuery : IRequest<int>
    {
        public int StoreId { get; set; }
        public int ItemId { get; set; }
    }
}
