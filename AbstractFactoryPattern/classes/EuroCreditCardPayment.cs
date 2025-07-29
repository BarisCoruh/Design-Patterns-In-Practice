using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryPattern.interfaces;

namespace AbstractFactoryPattern.classes
{
    public class EuroCreditCardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Europe - Paid €{amount} with credit card.");
        }
    }

    public class SepaTransferPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Europe - Sent €{amount} via SEPA transfer.");
        }
    }

    public class EuroQrPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Europe - Paid €{amount} via QR.");
        }
    }
}