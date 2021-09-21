using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(false, true, true); //bank, money, pp
            PaymentHandler bankPaymentHandler = new BankPaymentHandler(); 
            PaymentHandler moneyPaymentHnadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();

            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHnadler;

            bankPaymentHandler.Handle(receiver); // bank > pp > money

            moneyPaymentHnadler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = bankPaymentHandler;
            moneyPaymentHnadler.Handle(receiver); // money > pp > bank


            Console.ReadKey();
        }
    }
}
