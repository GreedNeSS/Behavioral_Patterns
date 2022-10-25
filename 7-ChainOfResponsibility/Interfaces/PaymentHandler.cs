using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _7_ChainOfResponsibility.Models;

namespace _7_ChainOfResponsibility.Interfaces
{
    public interface PaymentHandler
    {
        PaymentHandler? Successor { get; set; }
        void Handle(Receiver receiver);
    }
}
