using MediatR;

namespace CodeZone.Application.Features.Stores.Query.GetAllStores
{
    public class GetAllStoresQuery : IRequest<IReadOnlyList<StoreDto>>
    {
    }
}
