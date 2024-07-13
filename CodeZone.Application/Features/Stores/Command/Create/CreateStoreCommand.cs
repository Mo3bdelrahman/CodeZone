using MediatR;

namespace CodeZone.Application.Features.Stores.Command.Create
{
    public class CreateStoreCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
