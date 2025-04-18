using System;
using System.Diagnostics.Contracts;
namespace Abstract_Class
{
    abstract class Person
    {
        public string name;
        public int age;
        public string phoneNo;
        public abstract void PersonalInfo();
    }

    class Student : Person
    {
        public int id;
        public string dept;

        public override void PersonalInfo()
        {
            Console.WriteLine("Student Name : " + this.name);
            Console.WriteLine("Student Age : " + this.age);
            Console.WriteLine("Student Phone No : " + this.phoneNo);
            Console.WriteLine("Student Id : " + this.id);
            Console.WriteLine("Student Department : " + this.dept);
        }
    }

    class Teacher : Person
    {
        public int salary;
        public string qualification;

        public override void PersonalInfo()
        {
            Console.WriteLine("Teacher Name : " + this.name);
            Console.WriteLine("Teacher Age : " + this.age);
            Console.WriteLine("Teacher Phone No : " + this.phoneNo);
            Console.WriteLine("Teacher Salary : " + this.salary);
            Console.WriteLine("Teacher Qualification : " + this.qualification);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Student ob1 = new Student();
            ob1.name = "Ramij Wasith Rahat";
            ob1.age = 21;
            ob1.phoneNo = "01810287264";
            ob1.id = 2204022;
            ob1.dept = "CSE";
            ob1.PersonalInfo();

            Console.WriteLine("--------------------------");

            Teacher ob2 = new Teacher();
            ob2.name = "Ashim Dey";
            ob2.age = 30;
            ob2.phoneNo = "01827383638";
            ob2.salary = 500000;
            ob2.qualification = "MSc in CSE";
            ob2.PersonalInfo();
        }
    }
}
