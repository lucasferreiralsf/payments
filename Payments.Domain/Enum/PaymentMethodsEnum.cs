using System;
namespace Payments.Domain.Enum
{
    public enum PaymentMethodsEnum
    {
        Undefined = 0,
        BankSlip = 1,
        BankTransf = 2,
        CreditCard = 3,
        DebitCard = 4
    }
}
