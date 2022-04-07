using MediatR;
namespace TestCQRS.Application.Test.Queries
{
    public class GetQueryHandler : IRequestHandler<GetQuery, bool>
    {
        public async Task<bool> Handle(GetQuery request, CancellationToken cancellationToken) => await Task.Run(() => true);
    }
}
