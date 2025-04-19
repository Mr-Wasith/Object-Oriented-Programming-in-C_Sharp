using System;
using System.ComponentModel;

namespace ABD
{
    class Program
    {
        public void add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);
        }
        public void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public void add(string a, string b)
        {
            string c = a + b;
            Console.WriteLine(c);
        }

        static void main(string[] args)
        {
            Program p1 = new Program();
            p1.add();
            Program p2 = new Program();
            p2.add(2,3);
            Program p3 = new Program();
            p3.add("Ramij Wasith ", "Rahat");

        }
    }
}
