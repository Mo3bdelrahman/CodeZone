using AutoMapper;
using CodeZone.Application.Contracts.Persistence;
using CodeZone.Application.Features.Items.Query;
using CodeZone.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Stores.Query.GetAllStores
{
    public class GetAllStoresQueryHandler : IRequestHandler<GetAllStoresQuery, IReadOnlyList<StoreDto>>
    {
        private readonly IRepository<Store> _repository;
        private readonly IMapper _mapper;

        public GetAllStoresQueryHandler(IRepository<Store> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IReadOnlyList<StoreDto>> Handle(GetAllStoresQuery request, CancellationToken cancellationToken)
        {
            var stores = await _repository.GetAll();
            var storesDtos = _mapper.Map<IReadOnlyList<StoreDto>>(stores);
            return storesDtos;
        }
    }
}
