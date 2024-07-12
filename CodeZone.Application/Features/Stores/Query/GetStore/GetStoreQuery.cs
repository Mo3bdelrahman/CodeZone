using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Stores.Query.GetStore
{
    public class GetStoreQuery : IRequest<StoreDto>
    {
        public int Id { get; set; }
    }
}
