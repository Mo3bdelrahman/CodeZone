using System.ComponentModel.DataAnnotations;

namespace CodeZone.MVC.ViewModels.Item
{
    public class ItemViewModel
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Item name must be more than 2 & less than 50 characters")]
        public string Name { get; set; }
        public IFormFile? Image { get; set; }
    }
}
