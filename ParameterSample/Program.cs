using ReflectionDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterTest paramTest = new ParameterTest();
            int a = 10;
            int b = 20;
            Console.WriteLine("Value of a: " + a);
            Console.WriteLine("Value of b: " + b);
            Console.ReadKey();
            paramTest.Sum(ref a, ref b);
            Console.WriteLine("Value of a: " + a);
            Console.WriteLine("Value of b: " + b);
            Console.ReadKey();
        }
    }
    public class ParameterTest
    {
        public int Sum(int a, int b)
        {
            a = a + 10;
            b = b + 10;

            return a + b;
        }
        public int Sum(ref int a, ref int b)
        {
            a = a + 10;
            b = b + 20;
            return a + b;
            
        }
        public int Sum(int a, int b, out int c)
        {
            c = a + b;
            return c;
        }
        public void Sum(params int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }

}
