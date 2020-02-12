using System;
using System.Collections.Generic;
using System.Linq;
using Payments.Domain.ValueObjects;

namespace Payments.Domain.Entities
{
    public class Order : EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public DateTime DeliveryPreviousDate { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string AddressComplement { get; set; }
        public string AddressNumber { get; set; }
        public int PaymentMethodId { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

        public override void Validate()
        {
            if (!OrderItems.Any()) AddValidationMessage("Error: An order must have at least one item.");
            if (string.IsNullOrEmpty(ZipCode)) AddValidationMessage("Error: Zip code must be filled.");
        }
    }
}
