using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Stores.Command.Update
{
    public class UpdateStoreCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
