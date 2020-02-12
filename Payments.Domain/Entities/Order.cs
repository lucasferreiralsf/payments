using System;
using System.Collections.Generic;

namespace Payments.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public DateTime DeliveryPreviousDate { get; set; }
        public string CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string AddressComplement { get; set; }
        public string AddressNumber { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public Order()
        {
        }
    }
}
