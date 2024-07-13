using MediatR;

namespace CodeZone.Application.Features.Stores.Command.Delete
{
    public class DeleteStoreCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
