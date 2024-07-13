namespace CodeZone.Domain.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
        public IReadOnlyList<Store> Stores { get; set; }
    }
}
