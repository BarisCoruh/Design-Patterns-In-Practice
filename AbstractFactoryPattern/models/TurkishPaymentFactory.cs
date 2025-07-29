using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryPattern.interfaces;
using AbstractFactoryPattern.classes;

namespace AbstractFactoryPattern.models
{
    public class TurkishPaymentFactory : IPaymentFactory
    {
        public IPayment CreateCreditCardPayment() => new TurkishCreditCardPayment();
        public IPayment CreateEftPayment() => new TurkishEftPayment();
        public IPayment CreateQrPayment() => new TurkishQrPayment();
    }

}