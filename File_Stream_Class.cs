using System;
using System.IO;

public class FileStreamHandler
{
    private string filePath;

    public FileStreamHandler(string path)
    {
        filePath = path;
    }

    // Method to write data to a file using FileStream
    public void WriteToFile(byte[] data)
    {
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(data, 0, data.Length);
            }
            Console.WriteLine("Data written successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing to file: {ex.Message}");
        }
    }

    // Method to read data from a file using FileStream
    public void ReadFromFile()
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    Console.WriteLine("Data read from file:");
                    Console.WriteLine(System.Text.Encoding.UTF8.GetString(buffer));
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading from file: {ex.Message}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string path = "fileStreamExample.txt"; // Define the file path
        FileStreamHandler fileStreamHandler = new FileStreamHandler(path);

        // Writing to the file
        byte[] dataToWrite = System.Text.Encoding.UTF8.GetBytes("This is an example of FileStream in C#.");
        fileStreamHandler.WriteToFile(dataToWrite);

        // Reading from the file
        Console.WriteLine("\nReading from the file:");
        fileStreamHandler.ReadFromFile();
    }
}
