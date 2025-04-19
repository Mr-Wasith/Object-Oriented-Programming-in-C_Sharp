using System;
using System.IO;

namespace File_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\hp\Documents\Data.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exist");
                string data = File.ReadAllText(path);
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("Not exists");
            }
        }
    }
}