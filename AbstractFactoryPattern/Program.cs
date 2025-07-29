using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryPattern.interfaces;
using AbstractFactoryPattern.models;

internal class Program
{
    private static void Main(string[] args)
    {
        static void RunPaymentDemo(IPaymentFactory factory)
        {
            var card = factory.CreateCreditCardPayment();
            var eft = factory.CreateEftPayment();
            var qr = factory.CreateQrPayment();

            card.Pay(150);
            eft.Pay(100);
            qr.Pay(50);
        }

        RunPaymentDemo(new TurkishPaymentFactory());
        RunPaymentDemo(new EuropePaymentFactory());
    }
}
