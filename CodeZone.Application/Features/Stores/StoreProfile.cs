using AutoMapper;
using CodeZone.Application.Features.Items.Command.Update;
using CodeZone.Application.Features.Stores.Command.Create;
using CodeZone.Application.Features.Stores.Command.Update;
using CodeZone.Application.Features.Stores.Query;
using CodeZone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Stores
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            CreateMap<Store, StoreDto>();
            CreateMap<CreateStoreCommand, Store>();
            CreateMap<UpdateStoreCommand, Store>();
        }
    }
}
