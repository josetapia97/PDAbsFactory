using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExPayment
{
    public class PaymentService
    {
        //inyectando dependencias, sea cual sea la fabrica puede darme una instancia de:
        private readonly IGateway _paymentGateway;
        private readonly ITransactionLogger _transactionLogger;
        public PaymentService(IPaymentFactory paymentFactory)
        {
            _paymentGateway = paymentFactory.CreateGateway();
            _transactionLogger = paymentFactory.CreateTransactionLogger();
        }
        //para automatizar el metodo
        public void ProcessPayment(int  amount) 
        {
            _paymentGateway.ProcessPayment(amount);
            _transactionLogger.LogTransaction($"Payment of {amount}, was succesfull");
        }
    }
}
