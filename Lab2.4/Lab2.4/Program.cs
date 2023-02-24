using System;
using System.Collections.Generic;

class Program
{
    delegate int StringLength(string s);

    static void Main(string[] args)
    {
        List<string> strings = new List<string> { "Hello", "World", "it's", "me", "Mario" };

        StringLength lengthDelegate = s => s.Length;

        foreach (string s in strings)
        {
            Console.WriteLine($"Довжина рядка \"{s}\": {lengthDelegate(s)}");
        }
    }
}

