using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AbstractFactoryPattern.classes
{
    public class TurkishCreditCardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Türkiye - Kredi Kartıyla {amount}₺ ödendi.");
        }
    }

    public class TurkishEftPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Türkiye - EFT ile {amount}₺ gönderildi.");
        }
    }

    public class TurkishQrPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Türkiye - QR kod ile {amount}₺ ödendi.");
        }
    }
}