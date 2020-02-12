using System;
namespace Payments.Domain.Entities
{
    public class OrderItem : EntityBase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public OrderItem()
        {
        }

        public override void Validate()
        {
            if (ProductId == 0) AddValidationMessage("ProductId must be filled.");
        }
    }
}
