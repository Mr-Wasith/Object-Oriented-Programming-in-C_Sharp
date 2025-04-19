using System;
using System.Collections.Generic;

namespace LIST
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student()
            {
                Id = 2204022,
                Name = "Rahat",
                Dept = "CSE"

            };

            Student st2 = new Student()
            {
                Id = 2203022,
                Name = "Sajid",
                Dept = "EEE"

            };

            Student st3 = new Student()
            {
                Id = 2202022,
                Name = "Mahim",
                Dept = "ME"

            };

            List<Student> st = new List<Student>();
            
            st.Add(st1);
            st.Add(st2);
            st.Add(st3);

            foreach (Student student in st) 
            {
                Console.WriteLine($"Name : {student.Id}, Name : {student.Name}, Dept : {student.Dept}");
            }
            
        }
    }
}
