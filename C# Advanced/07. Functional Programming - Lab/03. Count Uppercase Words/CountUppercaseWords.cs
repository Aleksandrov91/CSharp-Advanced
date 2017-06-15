﻿using System;
using System.Linq;

namespace _03.Count_Uppercase_Words
{
    public class CountUppercaseWords
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => char.IsUpper(w[0]))));
        }
    }
}
