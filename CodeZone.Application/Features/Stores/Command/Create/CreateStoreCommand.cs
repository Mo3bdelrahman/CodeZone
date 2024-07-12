using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Stores.Command.Create
{
    public class CreateStoreCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
