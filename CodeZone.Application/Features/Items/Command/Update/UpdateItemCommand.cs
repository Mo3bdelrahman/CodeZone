using MediatR;
using Microsoft.AspNetCore.Http;

namespace CodeZone.Application.Features.Items.Command.Update
{
    public class UpdateItemCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile? Image { get; set; }
    }
}
