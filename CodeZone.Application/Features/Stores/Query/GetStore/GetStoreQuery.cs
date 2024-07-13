using MediatR;

namespace CodeZone.Application.Features.Stores.Query.GetStore
{
    public class GetStoreQuery : IRequest<StoreDetailesDto>
    {
        public int Id { get; set; }
    }
}
