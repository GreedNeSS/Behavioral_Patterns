using _7_ChainOfResponsibility.Implementations;
using _7_ChainOfResponsibility.Interfaces;
using _7_ChainOfResponsibility.Models;

Receiver receiver = new Receiver(false, true, true, 100);

PaymentHandler bankPaymentHandler = new BankPaymentHandler();
PaymentHandler payPalPaymentHandler = new PayPalPaymentHandler();
PaymentHandler moneyPaymentHandler = new MoneyPaymentHandler();
bankPaymentHandler.Successor = payPalPaymentHandler;
payPalPaymentHandler.Successor = moneyPaymentHandler;

bankPaymentHandler.Handle(receiver);

Console.Read();