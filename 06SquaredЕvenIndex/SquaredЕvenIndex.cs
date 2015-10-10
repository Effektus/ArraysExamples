using System;

class SquaredЕvenIndex
{
    static void Main()
    {
        // Обхождаме всички елементи на масива, намиращи се на четни позиции,
        // и повдигаме на квадрат стойността на всеки от тях.

        int[] array = new int[] { 1, 2, 3, 4, 5 };
        Console.Write("Output: ");
        for (int i = 0; i < array.Length; i += 2)
        {
            array[i] = array[i] * array[i];
            Console.Write(array[i] + " ");
        }
    }
}
//Output: 1 9 25