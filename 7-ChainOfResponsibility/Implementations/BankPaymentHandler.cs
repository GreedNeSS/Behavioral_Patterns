using _7_ChainOfResponsibility.Interfaces;
using _7_ChainOfResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ChainOfResponsibility.Implementations
{
    public class BankPaymentHandler : PaymentHandler
    {
        public PaymentHandler? Successor { get; set; }

        public void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer)
            {
                Console.WriteLine("Выполняем перевод через банк");
            }
            else if (Successor != null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}
