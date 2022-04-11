using System;

namespace MediatRExample.Med.Commands.Models
{
    public class CreateProductViewModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
    }
}
