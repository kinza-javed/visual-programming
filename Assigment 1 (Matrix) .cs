using System;

class Program
{
    static void Main()
    {
        // Create a 3x3x3 matrix
        int[,,] matrix = new int[3, 3, 3];

        // Take input from the user
        Console.WriteLine("Enter the elements of the 3x3x3 matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write($"matrix[{i},{j},{k}] = ");
                    matrix[i, j, k] = int.Parse(Console.ReadLine());
                }
            }
        }

        int sum = 0;

        // Sum the diagonal elements: (0,0,0), (1,1,1), (2,2,2)
        for (int i = 0; i < 3; i++)
        {
            sum += matrix[i, i, i];
        }

        // Output the sum
        Console.WriteLine("Sum of diagonal elements: " + sum);
    }
}
