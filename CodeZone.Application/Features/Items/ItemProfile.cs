using AutoMapper;
using CodeZone.Application.Features.Items.Command.Create;
using CodeZone.Application.Features.Items.Command.Update;
using CodeZone.Application.Features.Items.Query;
using CodeZone.Domain.Entities;


namespace CodeZone.Application.Features.Items
{
    internal class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<Item, ItemDto>();
            CreateMap<CreateItemCommand, Item>();
            CreateMap<UpdateItemCommand, Item>();
        }
    }
}
