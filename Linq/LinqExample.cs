using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class LinqExample
    {
        public void Example1()
        {
            List<string>Courses= new List<string>();
            Courses.Add("C Tutorial");
            Courses.Add("C++ Tutorial");
            Courses.Add("Java Tutorial");
            Courses.Add("web");
            Courses.Add("DBMS");
            //var result = from c in Courses where c.Equals("DBMS") select c;
            // var result = Courses.Where(c => c.Equals("DBMS"));
            var result = Courses.Where(c => c.Contains("Tutorial"));
           
            foreach (var c in result)
            {
            Console.WriteLine(c);
            }
        }
        public void Example2()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "AAA", "CSE"));
            students.Add(new Student(2, "BBB", "ECE"));
            students.Add(new Student(3, "CCC", "IT"));
            students.Add(new Student(4, "DDD", "CSE"));
            var stud = students.Where(s => s.Id == 3);
            foreach (var s in stud)
            {
                Console.WriteLine(s.Id+" "+s.Name+" "+s.Department);
            }
        }
    }
}
