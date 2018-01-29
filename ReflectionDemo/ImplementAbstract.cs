using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class ImplementAbstract :  TestAbstract,ITest1Interface
    {
        public override int Sum(int x, int y)
        {
            return x + y;
        }
        
        public string GetMode()
        {
            throw new NotImplementedException();
        }
    }

    public class TestIm : TestAbstract
    {
        public override int Sum(int x , int y)
        {
            return x + y*10;
        }
    }
}
