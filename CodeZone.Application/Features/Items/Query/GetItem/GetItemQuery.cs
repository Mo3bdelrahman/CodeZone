using MediatR;

namespace CodeZone.Application.Features.Items.Query.GetItem
{
    public class GetItemQuery : IRequest<ItemDto>
    {
        public int Id { get; set; }
    }
}
