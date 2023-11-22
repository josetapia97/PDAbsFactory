using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExPayment
{
    public interface IPaymentFactory
    {
        IGateway CreateGateway();
        ITransactionLogger CreateTransactionLogger();
    }
}
