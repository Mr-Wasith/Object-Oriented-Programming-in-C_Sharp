using System;
using System.IO;

namespace File_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"\C:\\Users\\hp\\Documents\\Data.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("Yes, There is a File");
            }
            else
            {
                {
                    Console.WriteLine("No, There is no File");
                }
            }
        }
    }
}