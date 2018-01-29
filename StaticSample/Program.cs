using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StaticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";
            var val = s.ConvertString(s);
            int count = 0;
            int countNumber = count.CountNumber(val);
            WriteLine(val + countNumber);
            ReadKey();
        }
    }

    public static class StaticTest
    {
        static int abc = 0;
        static DateTime currentDate = DateTime.Now;
        static StaticTest()
        {
            
        }
        public static DateTime CurrentDate()
        {
            return currentDate;
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static string ConvertString(this String abc, string value)
        {
            return abc = value;
        }
        public static int CountNumber(this int countNumber, string value)
        {
            return value.Split(new char[] { ' ', '.', ',' }).Length;
        }
    }


    

}
