using CodeZone.Application.Features.Items.Query;

namespace CodeZone.Application.Features.Stores.Query
{
    public class StoreDetailesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IReadOnlyList<ItemDto> Items { get; set; }
    }
}
