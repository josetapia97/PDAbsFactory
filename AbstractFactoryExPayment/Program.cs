
using AbstractFactoryExPayment;
using AbstractFactoryExPayment.Factories;

//inicializamos cualquiera de los dos con IPaiment, y seleccionamos la fabrica a utilizar
//caso paypal
IPaymentFactory paymentGWF = new PayPalFactory();

PaymentService paymentService = new PaymentService(paymentGWF);


int amount = 100000;
paymentService.ProcessPayment(amount);

//Si quieres cambiar a otro provider, solo cambias la factory
IPaymentFactory anotherPaymentGWF = new StripeFactory();

PaymentService another = new PaymentService(anotherPaymentGWF);

another.ProcessPayment(amount);