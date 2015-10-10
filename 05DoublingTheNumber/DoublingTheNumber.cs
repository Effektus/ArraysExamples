using System;

class DoublingTheNumber
{
    static void Main()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5 };

        Console.Write("Output: ");
        for (int i = 0; i < array.Length; i++)
        {
            // Dpubling the number
            array[i] = 2 * array[i];
            // Print the number
            Console.Write(array[i] + " ");
        }
    }
}
//Output: 2 4 6 8 10