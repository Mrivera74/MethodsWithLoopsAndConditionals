using System.Collections.Generic;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Step 1: Count from 100 to -100");
            //Write a method that will print to the console all numbers 1000 through -1000.

            for (int i = 100; i >= -100; i--)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine();
            Console.WriteLine("Step 2: Count by 3's up to 999");

            //Write a method that will print to the console numbers 3 through 999 by 3 each time.
            for (int lWarm = 3; lWarm <= 999; lWarm += 3)

            {
                Console.WriteLine($"{lWarm}");
            }

            Console.WriteLine();

            //Write a method to accept two integers as parameters and check whether they are equal or not.
            Console.WriteLine("Step 3: Compare Inputs");

            Console.WriteLine("Enter First Number");
            int thing1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int thing2 = int.Parse(Console.ReadLine());


            if (thing1 == thing2)
            {
                Console.WriteLine($"{thing1} is equal to {thing2}");
            }
            else
            {
                Console.WriteLine($"{thing1} does not equal to {thing2}");
            }

            //Write a method to check whether a given number is even or odd.

            //Write a method to check whether a given number is positive or negative.

            //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!



        }
    }
}