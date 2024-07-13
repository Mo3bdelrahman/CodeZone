namespace CodeZone.Domain.Entities
{
    public class StoreItem
    {
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public int Quantity { get; set; }
    }
}
