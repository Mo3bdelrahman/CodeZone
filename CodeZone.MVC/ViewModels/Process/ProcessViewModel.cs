using CodeZone.MVC.ViewModels.Item;
using CodeZone.MVC.ViewModels.Store;
using System.ComponentModel.DataAnnotations;

namespace CodeZone.MVC.ViewModels.Process
{
    public class ProcessViewModel
    {

        [Range(1, int.MaxValue, ErrorMessage = "The value must be greater than zero.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "You must Select Store")]
        [Range(1, int.MaxValue, ErrorMessage = "You must Select Store")]
        public int StoreId { get; set; }
        [Required(ErrorMessage = "You must Select Item")]
        [Range(1, int.MaxValue, ErrorMessage = "You must Select Item")]
        public int ItemId { get; set; }
        public IReadOnlyList<ItemListViewModel>? Items { get; set; }
        public IReadOnlyList<StoreViewModel>? Stores { get; set; }

    }
}
