using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class FactoryMethods
    {
        public static ICalculate GetCalculateObject(int choice)
        {
            ICalculate icalc = null;
            switch (choice)
            {
                case 1:
                    icalc = new FirstCalc();
                    break;
                case 2:
                    icalc = new SecondCalc();
                    break;
                default:
                    icalc = new FirstCalc();
                    break;
            }
            return icalc;
        }
    }
}
