using MediatR;
using Microsoft.AspNetCore.Http;

namespace CodeZone.Application.Features.Items.Command.Create
{
    public class CreateItemCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile? Image { get; set; }
    }
}
