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
            get { return Id == (int)PaymentMethodsEnum.BankSlip; }
        }

        public bool IsBankTransf
        {
            get { return Id == (int)PaymentMethodsEnum.BankTransf; }
        }
        public bool IsCreditCard
        {
            get { return Id == (int)PaymentMethodsEnum.CreditCard; }
        }
        public bool IsDebitCard
        {
            get { return Id == (int)PaymentMethodsEnum.DebitCard; }
        }
        public bool IsUndefined
        {
            get { return Id == (int)PaymentMethodsEnum.Undefined; }
        }

        public PaymentMethods()
        {
        }
    }
}
