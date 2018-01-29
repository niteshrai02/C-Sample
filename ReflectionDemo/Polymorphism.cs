using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class Polymorphism
    {
        public string TestOverload(int x)
        {
            return "";
        }

        public int TestOverload(string x)
        {
            return 2;
        }

        public int TestOverload()
        {
            return 2;
        }

        public void TestOverload(int x, int y)
        {

        }

        public string TestOverload(double c)
        {
            return "";
        }
    }


    public class TestBase
    {

        public virtual void Show()
        {
            Console.WriteLine("Show From Base Class.");
        }

        public string TestOverload(double c)
        {
            return "";
        }
    }

    public class Derived : TestBase
    {
        public override void Show()
        {
            Console.WriteLine("Show From Derived Class.");
        }
    }
}
