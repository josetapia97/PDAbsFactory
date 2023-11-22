using AbstractFactoryExPayment.ConcreteClasses.Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExPayment.Factories
{
    public class StripeFactory : IPaymentFactory
    {
        public IGateway CreateGateway()
        {
            return new StripeGateway();
        }

        public ITransactionLogger CreateTransactionLogger()
        {
            return new StripeTransactionLogger();
        }
    }
}
