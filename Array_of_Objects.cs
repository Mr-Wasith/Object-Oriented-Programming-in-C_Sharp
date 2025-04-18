using System;
namespace Array_Of_Object
{
    class Student
    {
        public string Name;
        public Student(string name)
        {
            this.Name = name; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[3];

            Student s1 = new Student("Ramij");
            Student s2 = new Student("Wasith");
            Student s3 = new Student("Rahat");

            student[0] = s1;
            student[1] = s2;
            student[2] = s3;

            foreach (Student st in student)
            {
                Console.WriteLine(st.Name);
            }


            //Alternative Way
            Student[] STUDENT = { new Student("CSE"), new Student("EEE"), new Student("ME") };

            foreach (Student st in STUDENT)
            {
                Console.WriteLine(st.Name);
            }

        }
    }

}