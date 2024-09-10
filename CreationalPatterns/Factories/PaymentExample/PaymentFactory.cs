using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Factories.PaymentExample
{
    public class PaymentFactory
    {
        // factory method pattern
        public static IPayment create(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    return new CreditCardPayment();

                case PaymentMethod.PayPal:
                    return new PayPalPayment();

                case PaymentMethod.GooglePay:
                    return new GooglePayPayment();

                default:
                    throw new NotSupportedException($"This type of payment ({paymentMethod}) is not supported.");
            }
        }
    }
}
