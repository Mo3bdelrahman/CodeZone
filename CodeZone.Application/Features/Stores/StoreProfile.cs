using AutoMapper;
using CodeZone.Application.Features.Stores.Command.Create;
using CodeZone.Application.Features.Stores.Command.Update;
using CodeZone.Application.Features.Stores.Query;
using CodeZone.Domain.Entities;

namespace CodeZone.Application.Features.Stores
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            CreateMap<Store, StoreDto>();
            CreateMap<Store, StoreDetailesDto>();
            CreateMap<CreateStoreCommand, Store>();
            CreateMap<UpdateStoreCommand, Store>();
        }
    }
}
