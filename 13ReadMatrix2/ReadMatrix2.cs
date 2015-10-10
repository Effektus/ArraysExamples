using System;

class ReadMatrix2
{
    static void Main()
    {
        Console.Write("Enter the number of the rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of the rows: ");
        int colomns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, colomns];

        Console.WriteLine("Enter the cells of the matrix: ");
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < colomns; column++)
            {
                Console.Write("matrix[{0},{1}] = ", row, column);
                string inputNumber = Console.ReadLine();
                matrix[row, column] = int.Parse(inputNumber);
            }
        }
    }
}