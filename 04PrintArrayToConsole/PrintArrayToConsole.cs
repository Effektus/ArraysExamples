using System;

class PrintArrayToConsole
{
    static void Main()
    {
        string[] array = { "one", "two", "three", "four" };

        for (int i = 0; i < array.Length; i++)
        {
            //print each element on a separate line
            Console.WriteLine("Element[{0}] = {1}", i, array[i]);
        }
    }
}
// Output:
//Element[0] = one
//Element[1] = two
//Element[2] = three
//Element[3] = four