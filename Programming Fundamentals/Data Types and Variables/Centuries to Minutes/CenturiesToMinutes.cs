﻿using System;

namespace Centuries_to_Minutes
{
    public class CenturiesToMinutes
    {
        public static void Main()
        {
            Console.Write("Centuries: ");
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
