using System;

namespace MediatRExample.Entities
{
    public class ProductEntity
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        public decimal amount { get; set; }
    }
}
