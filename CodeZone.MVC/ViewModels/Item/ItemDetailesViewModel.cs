using System.ComponentModel.DataAnnotations;

namespace CodeZone.MVC.ViewModels.Item
{
    public class ItemDetailesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
    }
}
