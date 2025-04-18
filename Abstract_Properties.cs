using System;
namespace Abstract_Properties
{
    abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract int Id { get; set; }
    }

    class Student : Person
    {
        string StudentName;
        int StudentId;
        public override string Name
        {
            set
            {
                this.StudentName = value;
            }
            get
            {
                return this.StudentName;
            }
        }
        public override int Id
        {
            set
            {
                this.StudentId = value;
            }
            get
            {
                return this.StudentId;
            }

        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Student ob = new Student();
            ob.Name = "Ramij Wasith Rahat";
            ob.Id = 2204022;
            Console.WriteLine(ob.Name);
            Console.WriteLine(ob.Id);
            Console.ReadLine();
        }
    }
}
