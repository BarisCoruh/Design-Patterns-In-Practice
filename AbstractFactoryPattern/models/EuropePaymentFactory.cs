using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryPattern.interfaces;
using AbstractFactoryPattern.classes;

namespace AbstractFactoryPattern.models
{
    public class EuropePaymentFactory : IPaymentFactory
    {
        public IPayment CreateCreditCardPayment() => new EuroCreditCardPayment();
        public IPayment CreateEftPayment() => new SepaTransferPayment();
        public IPayment CreateQrPayment() => new EuroQrPayment();
    }
}