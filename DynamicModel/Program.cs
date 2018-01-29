using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicModel
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic myModel = new ExpandoObject();
            myModel.Teacher = Teacher.GetAllTeacher();
            myModel.Student = Student.GetAllStudent();
            
        }
    }
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Teacher> GetAllTeacher()
        {
            List<Teacher> teach = new List<Teacher>();
            teach.Add(new Teacher()
            {
                Id = 1,
                Name = "John"
            });
            
            return teach;
            
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Student> GetAllStudent()
        {
            List<Student> teach = new List<Student>();
            teach.Add(new Student()
            {
                Id = 1,
                Name = "John"
            });

            return teach;

        }
    }
    
}
