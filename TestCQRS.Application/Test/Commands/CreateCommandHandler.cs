
using MediatR;

namespace TestCQRS.Application.Test.Commands
{
    public class CreateCommandHandler : IRequestHandler<CreateCommand, string>
    {
        public async Task<string> Handle(CreateCommand request, CancellationToken cancellationToken) => await Task.Run(() => request.value.ToString());
    }
}
