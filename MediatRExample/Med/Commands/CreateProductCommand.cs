using MediatR;
using MediatRExample.Med.Commands.Models;
using System;

namespace MediatRExample.Med.Commands
{
    public class CreateProductCommand: IRequest<CreateProductViewModel>
    {
        public String Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
    }
}
