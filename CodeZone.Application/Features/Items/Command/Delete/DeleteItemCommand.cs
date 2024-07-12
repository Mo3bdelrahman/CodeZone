using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Items.Command.Delete
{
    public class DeleteItemCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
