using AutoMapper;
using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;
using MediatR;

namespace CodeZone.Application.Features.Stores.Command.Update
{
    public class UpdateStoreCommandHandler : IRequestHandler<UpdateStoreCommand, bool>
    {
        private readonly IRepository<Store> _repository;
        private readonly IMapper _mapper;

        public UpdateStoreCommandHandler(IRepository<Store> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(UpdateStoreCommand request, CancellationToken cancellationToken)
        {
            Store store = _mapper.Map<Store>(request);
            var res = await _repository.Update(store);
            if (!res)
                throw new Exceptions.BadRequestException("Error While Update Store");

            return res;
        }
    }
}
