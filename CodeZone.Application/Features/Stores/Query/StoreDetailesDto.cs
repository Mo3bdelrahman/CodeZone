using CodeZone.Application.Features.Items.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Stores.Query
{
    public class StoreDetailesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IReadOnlyList<ItemDto> Items { get; set; }
    }
}
