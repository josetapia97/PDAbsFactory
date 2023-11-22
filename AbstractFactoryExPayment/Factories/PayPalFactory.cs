using AbstractFactoryExPayment.ConcreteClasses.Paypal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExPayment.Factories
{
    public class PayPalFactory : IPaymentFactory
    {
        public IGateway CreateGateway()
        {
            return new PaypalGateway();
        }

        public ITransactionLogger CreateTransactionLogger()
        {
            return new PaypalTransactionLogger();
        }
    }
}
