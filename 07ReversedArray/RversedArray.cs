using System;

class RversedArray
{
    static void Main()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5 };
        Console.Write("Reversed: ");
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
    }
}
//Reversed: 5 4 3 2 1