using System;
using Payments.Domain.Enum;

namespace Payments.Domain.ValueObjects
{
    public class PaymentMethods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsBankSlip
        {
            get { return Id (int) PaymentMethodsEnum}; set;
        }

        public PaymentMethods()
        {
        }
    }
}
