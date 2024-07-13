using MediatR;

namespace CodeZone.Application.Features.Stores.Command.Update
{
    public class UpdateStoreCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
