using System;

class PrintMatrix
{
    static void Main()
    {
        // Declare and initialize a matrix of size 2 x 4
        int[,] matrix =
        {
            { 1, 2, 3, 4 },  // row 0
            { 5, 6, 7, 8 },  // row 1
        };

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
// Print the matrix on the console
// Output:
// 1 2 3 4
// 5 6 7 8