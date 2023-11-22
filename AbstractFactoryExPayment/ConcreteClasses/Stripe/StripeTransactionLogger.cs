using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExPayment.ConcreteClasses.Stripe
{
    public class StripeTransactionLogger : ITransactionLogger
    {
        public void LogTransaction(string message)
        {
            Console.WriteLine($"Register in Stripe: {message}");
        }
    }
}
