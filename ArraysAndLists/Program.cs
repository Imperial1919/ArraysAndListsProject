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
            int[] first_array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* Create two Lists of type int.*/

            List<int> Decades = new List<int>();
            Decades.Add(1900);
            Decades.Add(1910);
            Decades.Add(1920);
            Decades.Add(1930);
            Decades.Add(1940);
            Decades.Add(1950);
            Decades.Add(1960);
            Decades.Add(1970);
            Decades.Add(1980);
            Decades.Add(1990);
            Decades.Add(2000);
            Decades.Add(2010);
            Decades.Add(2020);
           foreach(int Ten_years in Decades)
            {
                Console.Write("The Current year is:");
                Console.WriteLine(Ten_years);
                if (Ten_years >= 2020)
                {
                    Console.WriteLine("\t");
                }

            }
           

            List<int> Tfive_to_OneHun = new List<int>();
            Tfive_to_OneHun.Add(25);
            Tfive_to_OneHun.Add(50);
            Tfive_to_OneHun.Add(75);
            Tfive_to_OneHun.Add(100);

            //* Name one List "evens" Name the other List "odds"

            List<int> evens = new List<int>();
            evens.Add(2);

          for(int even = 2;even < 40; even +=2 )
            {
                Console.Write("Even Number:");
                Console.WriteLine(even);

                if (even > 36 )
                {
                    Console.WriteLine("\t");
                }
            }

            List<int> odds = new List<int>();
            evens.Add(1);

            for (int odd = 1; odd < 43; odd += 2)
            {
                Console.Write("Odd Number:");
                Console.WriteLine(odd);

                if (odd > 43)
                {
                    Console.WriteLine("\t");
                }
            }
             

            

            

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
