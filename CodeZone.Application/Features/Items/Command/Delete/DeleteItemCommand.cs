using MediatR;

namespace CodeZone.Application.Features.Items.Command.Delete
{
    public class DeleteItemCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
