using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Stores.Query.GetAllStores
{
    public class GetAllStoresQuery : IRequest<IReadOnlyList<StoreDto>>
    {
    }
}
