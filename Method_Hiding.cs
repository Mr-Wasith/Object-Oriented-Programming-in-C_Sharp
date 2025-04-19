using Method_hiding;
using System;

namespace Method_hiding
{
    class Parent
    {
        public void show()
        {
            Console.WriteLine("Parent class method");
        }
    }
    class Child : Parent 
    {
        public new void show()
        {
            Console.WriteLine("Child class method");
        }
    }

    class Program()
    {
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.show();
        }
    }
}
