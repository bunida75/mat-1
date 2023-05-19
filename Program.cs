using System;

class Program
{
    static void Main()
    {
        int level;
        do
        {
            Console.Write("Enter the level of Pascal's Triangle: ");
            if (!int.TryParse(Console.ReadLine(), out level))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                continue;
            }
            if (level < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
                continue;
                  }
            break;
        } while (true);

        int[][] triangle = new int[level + 1][];
        for (int i = 0; i <= level; i++)
        {
            triangle[i] = new int[i + 1];
            triangle[i][0] = triangle[i][i] = 1;
            for (int j = 1; j < i; j++)
            {
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }
        }

        for (int i = 0; i <= level; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(triangle[i][j] + " ");
            }
            Console.WriteLine();
              }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}