using MediatR;

namespace CodeZone.Application.Features.StoresItems.Command.PurchaseStoreItem
{
    public class PurchaseStoreItemCommand : IRequest<bool>
    {
        public int StoreId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
    }
}
