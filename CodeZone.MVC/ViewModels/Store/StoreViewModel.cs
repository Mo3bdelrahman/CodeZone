using System.ComponentModel.DataAnnotations;

namespace CodeZone.MVC.ViewModels.Store
{
    public class StoreViewModel
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Store name must be more than 2 & less than 50 characters")]
        public string Name { get; set; }
    }
}
