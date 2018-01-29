using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;

namespace CollectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[10];
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add("nitesh");
            foreach(var item in arrList)
            {
                Console.WriteLine(item);
            }
            
            
        }
    }
}
