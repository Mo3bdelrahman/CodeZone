using AutoMapper;
using CodeZone.Application.Features.StoresItems.Command.PurchaseStoreItem;
using CodeZone.Application.Features.StoresItems.Command.SellStoreItem;
using CodeZone.Domain.Entities;

namespace CodeZone.Application.Features.StoresItems
{
    internal class StoreItemProfile : Profile
    {
        public StoreItemProfile()
        {
            CreateMap<PurchaseStoreItemCommand, StoreItem>();
            CreateMap<SellStoreItemCommand, StoreItem>();
        }
    }
}
