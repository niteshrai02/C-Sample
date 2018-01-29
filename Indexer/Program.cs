using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexer index = new Indexer();
            index[0] = "A";
            index[1] = "B";
            index[2] = "C";
            Console.WriteLine(index[0], index[1], index[2]);
            Console.ReadKey();
        }
    }

    public class Indexer
    {
        private string[] range = new string[5];
        public string this[int dataRange]
        {
            get
            {
                return range[dataRange];
            }
            set
            {
                range[dataRange] = value;
            }
        }
    }
}
