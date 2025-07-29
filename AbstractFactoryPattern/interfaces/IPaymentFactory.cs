using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.interfaces
{
    public interface IPaymentFactory
    {
    IPayment CreateCreditCardPayment();
    IPayment CreateEftPayment();
    IPayment CreateQrPayment();
    }
}