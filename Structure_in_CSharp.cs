using System;
namespace STRUCTURE
{
    struct Person
    {
        public string name;
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p;
            p.age = 10;
            p.name = "John";
            Console.WriteLine(p.name);
            Console.WriteLine(p.age);
        }
    }
}