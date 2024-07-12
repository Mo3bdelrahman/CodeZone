using AutoMapper;
using CodeZone.Application.Contracts.Persistence;
using CodeZone.Application.Exceptions;
using CodeZone.Application.Features.Items.Query;
using CodeZone.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Stores.Query.GetStore
{
    public class GetStoreQueryHandler : IRequestHandler<GetStoreQuery, StoreDto>
    {
        private readonly IRepository<Store> _repository;
        private readonly IMapper _mapper;

        public GetStoreQueryHandler(IRepository<Store> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<StoreDto> Handle(GetStoreQuery request, CancellationToken cancellationToken)
        {
            var store = await _repository.GetById(request.Id);
            if (store == null)
                throw new NotFoundException("Not Found this store");

            return _mapper.Map<StoreDto>(store);
        }
    }
}
