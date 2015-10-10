using System;

class ForeachCapitals
{
    static void Main()
    {
        string[] capitals = new string[] { "Sofia", "Washington", "London", "Paris" };

        foreach (string capital in capitals)
        {
            Console.WriteLine(capital);
        }
    }
}
//Output:
//Sofia
//Washington
//London
//Paris
