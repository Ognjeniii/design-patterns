using CreationalPatterns.Factories.PaymentExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPayment payment = PaymentFactory.create(PaymentMethod.CreditCard);
            payment.Pay(1000);

            IPayment payment1 = PaymentFactory.create(PaymentMethod.ApplePay);
        }
    }
}
