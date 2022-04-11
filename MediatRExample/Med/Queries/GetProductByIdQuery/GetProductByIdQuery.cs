using MediatR;
using MediatRExample.Med.Queries.Models;
using System;

namespace MediatRExample.Med.Queries.GetProductByIdQuery
{
    public class GetProductByIdQuery : IRequest<GetProductViewModel>
    {
        public int Id { get; set; }
    }
}
