﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Convert_from_base_N_to_base_10
{
    public class ConvertFromBaseNToBase
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var baseNum = int.Parse(input[0]);
            var number = input[1];

            BigInteger result = 0;

            var digits = new Stack<int>(number.ToCharArray().Select(a => (int)char.GetNumericValue(a)));

            for (int i = 0; i < number.Length; i++)
            {
                var lastNum = digits.Pop();

                var raised = RaiseToPower(baseNum, i);

                result += lastNum * raised;
            }

            Console.WriteLine(result);
        }

        private static BigInteger RaiseToPower(int baseNum, int power)
        {
            if (power == 0)
            {
                return 1;
            }

            var result = new BigInteger(1);

            for (int i = 0; i < power; i++)
            {
                result *= baseNum;
            }

            return result;
        }
    }
}