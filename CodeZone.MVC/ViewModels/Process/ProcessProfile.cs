using AutoMapper;
using CodeZone.Application.Features.StoresItems.Command.PurchaseStoreItem;
using CodeZone.Application.Features.StoresItems.Command.SellStoreItem;

namespace CodeZone.MVC.ViewModels.Process
{
    public class ProcessProfile : Profile
    {
        public ProcessProfile()
        {
            CreateMap<ProcessViewModel, PurchaseStoreItemCommand>();
            CreateMap<ProcessViewModel, SellStoreItemCommand>();
        }
    }
}
