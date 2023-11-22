using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExPayment.ConcreteClasses.Paypal
{
    public class PaypalGateway : IGateway
    {
        public void ProcessPayment(int dinero)
        {
            Console.WriteLine($"Processing payment of {dinero} en Paypal");
        }
    }
}
