using CodeZone.Domain.Entities;
using CodeZone.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Contracts.Persistence
{
    public interface IProcessFactory
    {
        IProcessStrategy GetProcess(ProcessType processType);
    }
}
