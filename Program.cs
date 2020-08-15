using GLORY.FIZZBUZZ.CONSOLE.APP.GloryUtilities;
using System;

namespace GLORY.FIZZBUZZ.CONSOLE.APP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            Console.WriteLine(" ");
            Console.WriteLine("FIZZBUZZ SOLUTION");
            Console.WriteLine("___________________________________________________________________________________");
            Console.WriteLine(" ");

            #region Call Glory FizzBuzz Service
            var _callFizzBuzz = FizzBuzzService.ResultComputation(n);
            #endregion

            #region Loop Through The Result From Glory FizzBuzz Service Call
            int serial = 0;
            foreach (string num in _callFizzBuzz)
            {
                serial++;
                Console.WriteLine("The Out Result Of " + serial + " Is ======> " + num);
            }
            Console.WriteLine("_________________________________________________________________________");
            #endregion

            #region Explanation
            Console.WriteLine(" ");
            Console.WriteLine("EXPLANATION");
            Console.WriteLine(" ");

            string _explanation = String.Format("{0}{1}{2}{3}{4}",
                                            "The numbers 3, 6, 9, and 12 are multiples of 3 (but not 5), so i printed Fizz on those lines. The numbers 5 ",
                                            "and 10 are multiples of 5(but not 3), so i printed Buzz on those lines.",
                                            "",
                                            "The number 15 is a multiple of both 3 and 5, so i printed FizzBuzz on that line. None of the other values ",
                                            "is a multiple of either 3 or 5, so i printed the value of i on those lines.");
            Console.WriteLine(_explanation);
            Console.WriteLine("___________________________________________________________________________________");
            #endregion

            #region For  Explanation
            //This part is just for explanation.
            //Also the varable n can be any number and we can also make it dynamic by allowing the user to input his or her desired number
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("___________________________________________________________________________________");
            #endregion
            Console.WriteLine("Please Scrow Up To See Everything");


        }
    }
}
