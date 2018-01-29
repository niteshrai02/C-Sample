using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculate calc = FactoryMethods.GetCalculateObject(1);
            int x = calc.Add(2, 2);
            Console.WriteLine(x);
            Console.ReadKey();
            
        }
    }
}
