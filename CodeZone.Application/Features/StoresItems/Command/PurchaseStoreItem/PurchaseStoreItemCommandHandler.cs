using AutoMapper;
using CodeZone.Application.Contracts.Persistence;
using MediatR;
using CodeZone.Domain.Enums;
using CodeZone.Domain.Entities;

namespace CodeZone.Application.Features.StoresItems.Command.PurchaseStoreItem
{
    public class PurchaseStoreItemCommandHandler : IRequestHandler<PurchaseStoreItemCommand, bool>
    {
        private readonly IStoreItemRepository _repository;
        private readonly IMapper _mapper;
        private readonly IProcessFactory _processFactory;

        public PurchaseStoreItemCommandHandler(IStoreItemRepository repository, IMapper mapper,
            IProcessFactory processFactory)
        {
            _repository = repository;
            _mapper = mapper;
            _processFactory = processFactory;
        }

        public async Task<bool> Handle(PurchaseStoreItemCommand request, CancellationToken cancellationToken)
        {
            IProcessStrategy processStrategy;
            var storeItem = await _repository.GetStoreItem(request.StoreId, request.ItemId);
            if (storeItem == null)
            {
                processStrategy = _processFactory.GetProcess(ProcessType.PurchaseNew);
            }
            else
            {
                processStrategy = _processFactory.GetProcess(ProcessType.PurchaseOld);
            }
            var storeItemRequest = _mapper.Map<StoreItem>(request);

            var res = await processStrategy.ProcessStoreItem(storeItemRequest);

            if (!res)
                throw new Exceptions.BadRequestException("error While purchase Item");

            return res;               
        }
    }
}
