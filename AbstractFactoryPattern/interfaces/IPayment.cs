using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.interfaces
{
    public interface IPayment
    {
        void Pay(decimal amount);
    }
}