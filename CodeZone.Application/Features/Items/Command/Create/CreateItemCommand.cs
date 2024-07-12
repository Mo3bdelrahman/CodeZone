using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Items.Command.Create
{
    public class CreateItemCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile? Image { get; set; }
    }
}
