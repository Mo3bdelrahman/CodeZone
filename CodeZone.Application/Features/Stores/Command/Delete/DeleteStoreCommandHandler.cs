using CodeZone.Application.Contracts.Infrastructure;
using CodeZone.Application.Contracts.Persistence;
using CodeZone.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeZone.Application.Features.Stores.Command.Delete
{
    public class DeleteStoreCommandHandler : IRequestHandler<DeleteStoreCommand, bool>
    {
        private readonly IRepository<Store> _repository;

        public DeleteStoreCommandHandler(IRepository<Store> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(DeleteStoreCommand request, CancellationToken cancellationToken)
        {
            var item = await _repository.GetById(request.Id);
            if (item == null)
                throw new Exceptions.NotFoundException("Not Found this Store");

            var res = await _repository.Delete(item);
            if (!res)
                throw new Exceptions.BadRequestException("Error While Delete Store");

            return res;
        }
    }
}
