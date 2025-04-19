using System;
using System.IO;

namespace File_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\hp\Documents\Data.txt";
            string path2 = @"C:\Users\hp\Documents\Data1.txt";
            File.Copy(path, path2);
        }
    }
}