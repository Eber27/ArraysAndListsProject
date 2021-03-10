using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            var numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            var evens = new List<int>();

            var odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (var num in numbers)  // foreach option**
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                    //Console.WriteLine($" {num} is in the evens List");
                }
                else
                {
                    odds.Add(num);
                    //Console.WriteLine($" {num} is in the odds List");
                }

            }

            for (int i = 0; i < numbers.Length; i++)   // for option**
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
                else
                {
                    odds.Add(numbers[i]);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            foreach (var numberx in evens)
            {
                Console.WriteLine($" {numberx} is an even number");
            }

            foreach (var numberx in odds)
            {
                Console.WriteLine($" {numberx} is an odd number");
            }
        }
    }
}
