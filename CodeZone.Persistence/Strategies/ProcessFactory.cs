using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Enums;

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
