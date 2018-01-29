using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class AbstractionEncapsulation
    {
        public bool AddUser(string x)
        {
            var result = true;
            if(ValidateUser() == true)
            {
                AddDb();
            }
            return result;
        }

        private bool ValidateUser()
        {
            return true;
        }

        private void AddDb()
        {

        }
    }
}
