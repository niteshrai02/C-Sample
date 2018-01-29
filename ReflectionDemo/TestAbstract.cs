using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public abstract class TestAbstract
    {
        string message = "";
        string GetMessage()
        {
            return message;
        }
        public TestAbstract()
        {
            message = "Hello Abstract";
        }
        public abstract int Sum(int a, int b);

    }

    public abstract class Test1Abstract
    {
       public abstract string GetMessage();
    }
}
