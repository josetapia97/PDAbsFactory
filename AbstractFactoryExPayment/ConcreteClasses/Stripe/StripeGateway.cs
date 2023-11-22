using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExPayment.ConcreteClasses.Stripe
{
    public class StripeGateway : IGateway
    {
        public void ProcessPayment(int dinero)
        {
            Console.WriteLine($"Processing payment of {dinero} en Stripe");
        }
    }
}
