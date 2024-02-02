using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace IEnumerable
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Student std = new Student() { id = 1, name = "Aleem", standard = 10 };
            //Student std1 = new Student() { id = 2, name = "Ali", standard = 13 };
            //Student std2 = new Student() { id = 3, name = "waqas", standard = 11 };
            //Student std3 = new Student() { id = 4, name = "Ra", standard = 12 };
            //Student std4 = new Student() { id = 5, name = "Sh", standard = 10 };

            //School std5 = new School();
            //std5.Add(std);
            //std5.Add(std1);
            //std5.Add(std2);
            //std5.Add(std4);

            //foreach (Student s in std5) {
            //    Console.WriteLine($"ID :{s.id} Name:{s.name} Class: {s.standard}");
            //}
            int[,] num= { 
                       { 12, 75, 85 }, 
                       { 12, 'X', 50, } };
            int a = 'A';
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int standard { get; set; }
        
    }


   public class School : IEnumerable<Student> 
    {
        Student Std = new Student();
      
        List<Student> stdList=new List<Student>();

        public void Add(Student s)
        {
            stdList.Add(s);
        }

        public IEnumerator<Student> GetEnumerator()
        {
           return stdList.GetEnumerator();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}