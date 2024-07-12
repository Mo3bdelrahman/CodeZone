using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;
using CodeZone.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Persistence.Strategies
{
    public class ProcessFactory : IProcessFactory
    {
        private readonly IStoreItemRepository _repository;

        public ProcessFactory(IStoreItemRepository repository)
        {
            _repository = repository;
        }

        public IProcessStrategy GetProcess(ProcessType processType)
        {
            IProcessStrategy processStrategy = processType switch
            {
                ProcessType.PurchaseNew => new PurchaseNewStrategy(_repository),
                ProcessType.PurchaseOld => new PurchaseOldStrategy(_repository),
                ProcessType.Sell => new SellStrategy(_repository),
                _ => new DefaultProcessStrategy()
            };
            return processStrategy;
        }
    }
}
