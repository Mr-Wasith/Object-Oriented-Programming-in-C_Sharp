using System;
namespace Destructor
{
    class Person
    {
        public string Name;
        public int Age;

        public Person(string Name,int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public string getName()
        {
            return this.Name;
        }
        public int getAge()
        {
            return this.Age;
        }
        ~Person()
        {
            Console.WriteLine("Destructor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Rahat",21);
            Console.WriteLine(p.getName());
            Console.WriteLine(p.getAge());
        }
    }

}
