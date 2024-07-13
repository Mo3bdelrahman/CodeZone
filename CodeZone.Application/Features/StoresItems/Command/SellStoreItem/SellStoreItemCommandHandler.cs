using AutoMapper;
using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;
using CodeZone.Domain.Enums;
using MediatR;

namespace CodeZone.Application.Features.StoresItems.Command.SellStoreItem
{
    public class SellStoreItemCommandHandler : IRequestHandler<SellStoreItemCommand, bool>
    {
        private readonly IStoreItemRepository _repository;
        private readonly IMapper _mapper;
        private readonly IProcessFactory _processFactory;

        public SellStoreItemCommandHandler(IStoreItemRepository repository, IMapper mapper, IProcessFactory processFactory)
        {
            _repository = repository;
            _mapper = mapper;
            _processFactory = processFactory;
        }
        public async Task<bool> Handle(SellStoreItemCommand request, CancellationToken cancellationToken)
        {
            var storeItem = await _repository.GetStoreItem(request.StoreId, request.ItemId);
            if (storeItem == null)
                throw new Exceptions.BadRequestException("error While Sell Item");

            IProcessStrategy processStrategy = _processFactory.GetProcess(ProcessType.Sell);

            var storeItemRequest = _mapper.Map<StoreItem>(request);

            var res = await processStrategy.ProcessStoreItem(storeItemRequest);

            if (!res)
                throw new Exceptions.BadRequestException("error While Sell Item");

            return res;
        }
    }
}
