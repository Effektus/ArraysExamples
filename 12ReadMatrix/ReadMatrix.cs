using System;

class ReadMatrix
{
    static void Main()
    {
        Console.Write("Enter the number of the rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of the columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int [rows, cols];

        Console.WriteLine("Enter the cells of the matrix: ");

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(" " + matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
//Output:
//Enter the number of the rows: 3
//Enter the number of the columns: 3
//Enter the cells of the matrix:
//matrix[0, 0] = 1
//matrix[0, 1] = 2
//matrix[0, 2] = 3
//matrix[1, 0] = 4
//matrix[1, 1] = 5
//matrix[1, 2] = 6
//matrix[2, 0] = 7
//matrix[2, 1] = 8
//matrix[2, 2] = 9
// 1 2 3
// 4 5 6
// 7 8 9
//Press any key to continue . . .