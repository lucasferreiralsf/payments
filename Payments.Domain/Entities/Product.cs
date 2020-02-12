using System;
namespace Payments.Domain.Entities
{
    public class Product : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Product()
        {
        }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
