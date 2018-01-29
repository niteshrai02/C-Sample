using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var reflection = ConfigurationManager.AppSettings["Reflection"];
            var valueType = ConfigurationManager.AppSettings["ValueReferenceType"];
            var singleton = ConfigurationManager.AppSettings["SingleTon"];
            var predicate = ConfigurationManager.AppSettings["Predicate"];
            var Func = ConfigurationManager.AppSettings["Func"];
            if (reflection == "true")
            {
                #region Reflection
                #region Knowledge Section
                //So basically using reflection and Type we can get all the information regarding
                //a class and assembly such as Methods, Properties Fields etc.

                //In the below code i am using typeof to create a object which contains all the info regarding Test
                //class and then using that iterating through method info and property info
                #endregion



                Type testType = typeof(Test);

                MethodInfo[] v = testType.GetMethods();
                PropertyInfo[] p = testType.GetProperties();
                object obj = Activator.CreateInstance(testType);
                
                foreach (var item in v)
                {
                    Console.WriteLine("Value: " + item.Name);
                    Console.ReadKey();
                }
                foreach (var item in p)
                {
                    Console.WriteLine("Value: " + item.Name);
                    Console.ReadKey();
                }
                #endregion
            }

            if(valueType == "true")
            {
                #region Value and Reference Types

                #region Knowledge Section
                //Value types are basically those types which are stored in stack and when updated or chnaged after 
                // initialization a copy of type will be created in the memory and value will get updated
                // Reference types are object which are stored in heap and when updated with other object reference, then
                //reference will be updated
                #endregion

                Test obj1 = new Test();
                obj1.firstValue = 10;

                Test obj2 = obj1;
                Console.WriteLine("First Obj:" + obj1.firstValue + "Second Obj: " + obj2.firstValue);
                obj2.firstValue = 25;
                Console.WriteLine("First Obj:" + obj1.firstValue + "Second Obj: " + obj2.firstValue);
                Console.ReadLine();

                int firstValue = 10;
                int secondValue = firstValue;

                Console.WriteLine("First Obj:" + firstValue + "Second Obj: " + secondValue);
                secondValue = 25;
                Console.WriteLine("First Obj:" + firstValue + "Second Obj: " + secondValue);
                Console.ReadLine();


                #endregion

            }
            if(singleton == "true")
            {
                #region Singleton Pattern
                //We cannot directly create object of Logger class as its constructor is marked as private
                //Singleton pattern means in the entire application we can create only one instance of the class
                // and use it. We cannot create instance wherever we want.

                Logger log = Logger.GetInstance();
                log.WriteToFile("Helllo Singleton");
                Console.ReadKey();
                #endregion
            }

            if(predicate == "true")
            {
                #region Predicate 
                // It is a specialized version of Func which takes an argument evaluates a value against a set of criteria
                // and returns a boolean value as the result
                Predicate<int> isOne = x => x == 1;
                Predicate<List<int>> listCount = x => x.Count > 2;

                List<int> value = new List<int>();
                value.Add(1);
                value.Add(2);
                value.Add(3);

                Console.WriteLine("Predicate is " + listCount.Invoke(value));
                Console.WriteLine("Predicate is " + isOne.Invoke(1));
                Console.ReadKey();

                #endregion
            }

            if(Func == "true")
            {
                #region Func
                // It is delegate for a function that may or may not take a parameter and return a value
                // Create a Func instance that has one parameter and one return value.
                // ... Parameter is an integer, result value is a string.
                //
                Func<int, string> func1 = (a) => string.Format("Hello {0}", a);
                //
                // Func instance with two parameters and one result.
                // ... Receives bool and int, returns string.
                //
                Func<bool, int, string> func2 = (b, x) =>
                    string.Format("string = {0} and {1}", b, x);
                //
                // Func instance that has no parameters and one result value.
                //
                Func<double> func3 = () => Math.PI / 2;

                //
                // Call the Invoke instance method on the anonymous functions.
                //
                Console.WriteLine(func1.Invoke(5));
                Console.WriteLine(func2.Invoke(true, 10));
                Console.WriteLine(func3.Invoke());
                #endregion
            }


            //Example of Func,Predicate and Action
            Func<int, string, decimal, string> ShowEmp = new Func<int, string, decimal, string>(CreateEmployee);
            Console.WriteLine(ShowEmp(10, "Nitesh", 250));

            Action<int, string> GetFullName = new Action<int, string>(ShowFullName);
            Console.WriteLine("Hello", "Moto");

            Predicate<int> IsGreater = new Predicate<int>(SalaryGreater);
            Console.ReadKey();


            Polymorphism pl = new Polymorphism();
            pl.TestOverload(2.5);
            pl.TestOverload(2);
            pl.TestOverload("ni");
            pl.TestOverload();

            TestBase baseobj = new TestBase();
            baseobj.Show();

            Derived der = new Derived();
            der.TestOverload(2.5);

            AbstractionEncapsulation abenObj = new AbstractionEncapsulation();
            abenObj.AddUser("Hello");   // This is the outer world for AbstractionEncapsulation class so only exposing
                                        // AddUser method but how internally different methods are called not exposed

            // Abstract Call
            ImplementAbstract testAbs = new ImplementAbstract();
            Console.WriteLine(testAbs.Sum(10, 10));

            //Enumeration

                        

        }

        private static bool SalaryGreater(int obj)
        {
            return obj > 100 ? true : false;
        }

        private static void ShowFullName(int arg1, string arg2)
        {
            Console.WriteLine("Full Name " + arg1 + arg2);
        }

        private static string CreateEmployee(int arg1, string arg2, decimal arg3)
        {
            return string.Format("This is your data {0} {1} {2:c}", arg1, arg2, arg3);
        }
    }

    public class Test
    {
        public string Name { get; set; }

        public int firstValue;
        public void TestMethod()
        {
            int value = 0;

        }

        public enum Day
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

        Array names = Enum.GetValues(typeof(Day));
        
        
        
    }

    }
