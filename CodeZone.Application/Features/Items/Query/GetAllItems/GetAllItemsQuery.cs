using MediatR;

namespace CodeZone.Application.Features.Items.Query.GetAllItems
{
    public class GetAllItemsQuery : IRequest<IReadOnlyList<ItemDto>>
    {
    }
}
