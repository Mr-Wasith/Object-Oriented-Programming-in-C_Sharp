using System;
namespace Multiple_Inheritance
{
   interface men
    {
        public void show1();
    }
    class women
    {
        public void show2()
        {
            Console.WriteLine("Class Method");

        }
    }
    class child : women,men
    {
        public void show1()
        {
            Console.WriteLine("Interface Method");
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            child ob = new child();
            ob.show1();
            ob.show2();
        }
    }
}

    
