using System;
using System.IO;

public class FileHandler
{
    private string filePath;

    public FileHandler(string path)
    {
        filePath = path;
    }

    public void WriteToFile(string content)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(content);
            }
            Console.WriteLine("Data written successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing to file: {ex.Message}");
        }
    }

    public void ReadFromFile()
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
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
        string path = "example.txt"; // Define the file path
        FileHandler fileHandler = new FileHandler(path);

        // Writing to the file
        fileHandler.WriteToFile("Hello, world!");
        fileHandler.WriteToFile("This is a file handling example in C#.");

        // Reading from the file
        Console.WriteLine("\nReading from the file:");
        fileHandler.ReadFromFile();
    }
}
