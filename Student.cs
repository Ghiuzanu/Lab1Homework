using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Homework
{
    public class Student
    {
        public string First {  get; set; }
        public string Last { get; set; }
        public int Year {  get; set; }

        public List<Subject> Subjects { get; set; }

        public void printSubjects()
        {
            Console.WriteLine(First + " " + Last);
            foreach (Subject i in Subjects)
            {
                Console.WriteLine(i.Title + " " + i.Duration);
            }
            Console.WriteLine();
        }

    }
}
