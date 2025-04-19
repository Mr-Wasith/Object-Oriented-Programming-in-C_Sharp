using System;

// Define the first namespace
namespace NamespaceA
{
    public class MyClass
    {
        public void Display()
        {
            Console.WriteLine("This is MyClass from NamespaceA");
        }
    }
}

// Define the second namespace
namespace NamespaceB
{
    public class MyClass
    {
        public void Display()
        {
            Console.WriteLine("This is MyClass from NamespaceB");
        }
    }
}

// Define the third namespace
namespace NamespaceC
{
    public class MyClass
    {
        public void Display()
        {
            Console.WriteLine("This is MyClass from NamespaceC");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using fully qualified names to create instances of MyClass from different namespaces
        NamespaceA.MyClass myClassA = new NamespaceA.MyClass();
        NamespaceB.MyClass myClassB = new NamespaceB.MyClass();
        NamespaceC.MyClass myClassC = new NamespaceC.MyClass();

        // Calling the Display method on each instance
        myClassA.Display(); // Output: This is MyClass from NamespaceA
        myClassB.Display(); // Output: This is MyClass from NamespaceB
        myClassC.Display(); // Output: This is MyClass from NamespaceC
    }
}
