using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            RefOut refOut = new RefOut();

            string refValue = "Ref";
            Console.WriteLine(refValue);
            int outValue;
            //Console.WriteLine(outValue);
            refOut.ChangeRef(ref refValue);
            refOut.ChangeOut(out outValue);
            Console.WriteLine(refValue);
            Console.WriteLine(outValue);
            Console.ReadKey();
        }
    }

    public class RefOut
    {
        public string ChangeRef(ref string value)
        {
            value = "Value Changed in Ref";
            return value;
        }
        public int ChangeOut(out int value)
        {
            value = 2;
            value = value * 2;
            return value;
        }
    }
}
