using MediatR;
using MediatRExample.Med.Queries.Models;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.Med.Queries.GetProductByIdQuery
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            // Get Product Repository
            var viewModel = new GetProductViewModel()
            {
                Id = 1,
                Name = "Book"
            };
            return Task.FromResult(viewModel);
        }
    }
}
