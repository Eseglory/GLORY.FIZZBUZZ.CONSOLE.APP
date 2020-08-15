﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GLORY.FIZZBUZZ.CONSOLE.APP.GloryUtilities
{
    public class FizzBuzzService
    {
        public static List<string> ResultComputation(int n)
        {
            return Enumerable.Range(1, n)
                .Select(a => String.Format("{0}{1}",
                                           a % 3 == 0 ? "Fizz" : string.Empty,
                                           a % 5 == 0 ? "Buzz" : string.Empty))
                .Select((b, i) => String.IsNullOrEmpty(b) ? (i + 1).ToString() : b)
                .ToList();
        }
    }
}
