using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            YieldSample ys = new YieldSample();
            ys.YieldReturn(list);
            Console.WriteLine();
            
                     
        }
    }

    public class YieldSample
    {
        public IEnumerable<int> YieldReturn(List<int> list)
        {
            foreach(int i in list)
            {
                if (i >= 3)
                    yield return i;
            }
        }
    }
}
