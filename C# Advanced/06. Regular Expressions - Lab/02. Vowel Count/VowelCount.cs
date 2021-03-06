﻿namespace _02.Vowel_Count
{
    using System;
    using System.Text.RegularExpressions;

    public class VowelCount
    {
        public static void Main()
        {
            var pattern = @"[aeiouy]";
            var input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern, RegexOptions.IgnoreCase);

            Console.WriteLine($"Vowels: {matches.Count}");
        }
    }
}
