using CodeZone.Domain.Enums;

namespace CodeZone.Application.Contracts.Persistence
{
    public interface IProcessFactory
    {
        IProcessStrategy GetProcess(ProcessType processType);
    }
}
