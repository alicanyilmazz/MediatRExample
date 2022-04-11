using MediatR;
using MediatRExample.Med.Queries.Models;
using System.Collections.Generic;

namespace MediatRExample.Med.Queries.GetAllProductQuery
{
    public class GetAllProductQuery: IRequest<List<GetProductViewModel>>
    {

    }
}
