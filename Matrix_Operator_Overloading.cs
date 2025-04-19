using System;

class Matrix
{
    private int[,] mat = new int[3, 3];

    // Constructor to initialize matrix with default values
    public Matrix()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                mat[i, j] = 0;
            }
        }
    }

    // Overload + operator for Matrix addition
    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        Matrix result = new Matrix();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result.mat[i, j] = m1.mat[i, j] + m2.mat[i, j];
            }
        }
        return result;
    }

    // Overload - operator for Matrix subtraction
    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        Matrix result = new Matrix();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result.mat[i, j] = m1.mat[i, j] - m2.mat[i, j];
            }
        }
        return result;
    }

    // Overload * operator for Matrix multiplication
    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        Matrix result = new Matrix();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result.mat[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    result.mat[i, j] += m1.mat[i, k] * m2.mat[k, j];
                }
            }
        }
        return result;
    }
    public void InputMatrix()
    {
        Console.WriteLine("Enter the matrix values (3x3):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter value for mat[{i}][{j}]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Method to display the matrix
    public void Display()
    {
        Console.WriteLine("Matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(mat[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Matrix m1 = new Matrix();
        Matrix m2 = new Matrix();
        Matrix result;

        // Input matrices
        Console.WriteLine("Matrix 1:");
        m1.InputMatrix();
        Console.WriteLine("Matrix 2:");
        m2.InputMatrix();

        // Add matrices
        result = m1 + m2;
        Console.WriteLine("\nMatrix Addition Result:");
        result.Display();

        // Subtract matrices
        result = m1 - m2;
        Console.WriteLine("\nMatrix Subtraction Result:");
        result.Display();

        // Multiply matrices
        result = m1 * m2;
        Console.WriteLine("\nMatrix Multiplication Result:");
        result.Display();
    }
}

