using AutoMapper;
using CodeZone.Application.Features.Stores.Command.Create;
using CodeZone.Application.Features.Stores.Command.Update;
using CodeZone.Application.Features.Stores.Query;

namespace CodeZone.MVC.ViewModels.Store
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            CreateMap<StoreDto, StoreViewModel>();
            CreateMap<StoreDetailesDto, StoreDetailesViewModel>();
            CreateMap<StoreDetailesDto, StoreViewModel>();
            CreateMap<StoreViewModel, CreateStoreCommand>();
            CreateMap<StoreViewModel, UpdateStoreCommand>();
        }
    }
}
