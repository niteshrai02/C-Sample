using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.Console;

namespace TupleDataStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            TupleStruct obj = new TupleStruct();
            var result = obj.GetTupleValue();
            WriteLine("First Object " + result.Item1 + " Second Object " + result.Item2 + " Third Object " + result.Item3);
            ReadKey();                       
        }
    }

    public class TupleStruct
    {
        public Tuple<int,string,double> GetTupleValue()
        {
            Tuple<int, string, double> tupleObject = Tuple.Create(1, "Nitesh", 2.445);
            return tupleObject;
            
        }
        
        
    }
}
