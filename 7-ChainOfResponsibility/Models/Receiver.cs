using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ChainOfResponsibility.Models
{
    public class Receiver
    {
        public bool BankTransfer { get; set; }
        public bool MoneyTransfer { get; set; }
        public bool PayPalTransfer { get; set; }
        public int TransferAmount { get; set; }

        public Receiver(bool bankTransfer, bool moneyTransfer, bool payPalTransfer, int transferAmount)
        {
            BankTransfer = bankTransfer;
            MoneyTransfer = moneyTransfer;
            PayPalTransfer = payPalTransfer;
            TransferAmount = transferAmount;
        }
    }
}
