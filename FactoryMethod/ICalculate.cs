using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface ICalculate
    {
        int Add(int x, int y);
        int Sub(int x, int y);
    }
}
