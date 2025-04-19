using System;

namespace ABC
{
    class Parent
    {
        public virtual void print()
        {
            Console.WriteLine("PARENTS Class Method");
        }
    }
    class Child : Parent
    {
        public override void print()
        {
            Console.WriteLine("CHILD Class Method");
        }
    }

    class Program
    {
        static void Main(string[] args) {
            Parent obj = new Child();
            obj.print();
            Child child = new Child();
            child.print();
            Parent parent = new Parent();
            parent.print();
        }
    }
}