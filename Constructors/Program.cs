using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConstructorSample cs = new ConstructorSample(10);
            //ConstructorSample cs1 = new ConstructorSample();
            //cs.Salary();
            Console.WriteLine();
            Console.ReadKey();
        }
    }

    public class ConstructorSample
    {
        public int count = 0;
        public static DateTime currentDate = DateTime.Now;
        public ConstructorSample()
        {
            Console.WriteLine("Default");

        }
        public ConstructorSample(int a)
        {
            this.count = a;
            Console.WriteLine("Parameterized");
        }

        static ConstructorSample()
        {
            Console.WriteLine("Static");
        }

        public DateTime Salary()
        {
            Console.WriteLine(currentDate);
            return currentDate;
        }
    }
}
