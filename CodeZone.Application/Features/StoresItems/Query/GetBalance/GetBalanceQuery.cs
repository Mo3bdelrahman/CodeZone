using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.StoresItems.Query.GetBalance
{
    public class GetBalanceQuery : IRequest<int>
    {
        public int StoreId { get; set; }
        public int ItemId { get; set; }
    }
}
