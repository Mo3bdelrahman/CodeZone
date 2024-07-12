using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Items.Query.GetAllItems
{
    public class GetAllItemsQuery : IRequest<IReadOnlyList<ItemDto>>
    {
    }
}
