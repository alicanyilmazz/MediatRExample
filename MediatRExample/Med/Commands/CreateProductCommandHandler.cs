using MediatR;
using MediatRExample.Med.Commands.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.Med.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductViewModel>
    {
        public Task<CreateProductViewModel> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // repository aracılıgı ile veri veritabanına gönderilir.
            return Task.FromResult(new CreateProductViewModel() { Id = 3, Name = "Harry Pottery", Quantity = 12, Value = 19 });
        }
    }
}
