using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Items.Command.Update
{
    public class UpdateItemCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile? Image { get; set; }
    }
}
