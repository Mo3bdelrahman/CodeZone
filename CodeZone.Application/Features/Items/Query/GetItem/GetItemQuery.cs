using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Items.Query.GetItem
{
    public class GetItemQuery : IRequest<ItemDto>
    {
        public int Id { get; set; }
    }
}
