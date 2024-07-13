using AutoMapper;
using CodeZone.Application.Features.Items.Command.Create;
using CodeZone.Application.Features.Items.Command.Update;
using CodeZone.Application.Features.Items.Query;

namespace CodeZone.MVC.ViewModels.Item
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<ItemDto, ItemListViewModel>();
            CreateMap<ItemDto, ItemDetailesViewModel>();
            CreateMap<ItemDto, ItemViewModel>()
                .ForMember(dest => dest.Image, opt => opt.Ignore());
            CreateMap<ItemViewModel, CreateItemCommand>();
            CreateMap<ItemViewModel, UpdateItemCommand>();
        }
    }
}
