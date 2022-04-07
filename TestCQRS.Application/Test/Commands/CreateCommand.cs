
using MediatR;

namespace TestCQRS.Application.Test.Commands
{
    public class CreateCommand: IRequest<string>
    {
        public bool value { get; set; }
    }
}
