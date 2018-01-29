using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class Logger
    {
        private static Logger logger = null;

        private Logger()
        {

        }
        public static Logger GetInstance()
        {
            //YODA Expression
            if(null == logger)
            {
                logger = new Logger();
            }
            return logger;
        }
        public void WriteToFile(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
