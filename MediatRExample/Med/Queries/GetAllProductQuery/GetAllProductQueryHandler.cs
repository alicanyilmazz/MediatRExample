using MediatR;
using MediatRExample.Med.Queries.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.Med.Queries.GetAllProductQuery
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductViewModel>>
    {
        public Task<List<GetProductViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var model = new GetProductViewModel()
            {
                Id = 1,
                Name = "Book"
            };

            var model2 = new GetProductViewModel()
            {
                Id = 2,
                Name = "Laptop"
            };

            return Task.FromResult(new List<GetProductViewModel>() {model,model2});
        }
    }
}
