using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AnonymousType_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee()
            {
                FirstName = "Nitss",
                Id = 1

            });
            //emp.Add(new Employee()
            //{
            //    FirstName = "abc",
            //    Id = 1
            //});
                var anonymousType = from m in emp
                                select new
                                {
                                    Name = m.FirstName
                                };
            foreach(var item in anonymousType)
            {
                WriteLine(item.Name);
            }
            
        }
    }
    public class Employee
    {
        public string FirstName
        {
            //get;set;
            get
            {
                return this.FirstName;
            }
            set
            {
                FirstName = value;
            }
        }
        public int Id
        {
            //get;set;
            get
            {
                return this.Id;
            }
            set
            {
                Id = value;
            }
        }
    }
}
