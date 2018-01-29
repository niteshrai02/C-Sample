using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
            BaseGC oBaseGC = new BaseGC();
            Console.WriteLine("BaseGC Generation is :" + GC.GetGeneration(oBaseGC));
            Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
            Console.ReadKey();
        }
    }
    public class BaseGC
    {

    }
}
