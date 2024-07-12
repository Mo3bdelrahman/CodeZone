using AutoMapper;
using CodeZone.Application.Contracts.Infrastructure;
using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Stores.Command.Create
{
    public class CreateStoreCommandHandler : IRequestHandler<CreateStoreCommand, int>
    {
        private readonly IRepository<Store> _repository;
        private readonly IMapper _mapper;

        public CreateStoreCommandHandler(IRepository<Store> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateStoreCommand request, CancellationToken cancellationToken)
        {
            Store store = _mapper.Map<Store>(request);
            var res = await _repository.Add(store);
            if (!res)
                throw new Exceptions.BadRequestException("Error While create Store");

            return store.Id;
        }
    }
}
