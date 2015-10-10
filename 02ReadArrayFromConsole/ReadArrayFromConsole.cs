using System;

class ReadArrayFromConsole
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        //read form conslole
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        //print to console
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}