using System;

class PrintWithStringJoin
{
    static void Main()
    {
        int[] intArray = { 1, 2, 3, 4, 5 };
        Console.Write("Output int: ");
        Console.Write(string.Join(", ", intArray));
        Console.WriteLine();

        string[] stringArray = { "one", "two", "three", "four", "five" };
        Console.Write("Output string: ");
        Console.Write(string.Join(", ", stringArray));
        Console.WriteLine();
    }
}
//Output int: 1, 2, 3, 4, 5
//Output string: one, two, three, four, five
