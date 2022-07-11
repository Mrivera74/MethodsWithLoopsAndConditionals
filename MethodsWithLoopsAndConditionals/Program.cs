using System.Collections.Generic;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that will print to the console all numbers 1000 through - 1000.
            Console.WriteLine("1: Count from 100 to -100");
            Console.WriteLine();

            for (int i = 100; i >= -100; i--)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine();
            Console.WriteLine();


            //Write a method that will print to the console numbers 3 through 999 by 3 each time.
            Console.WriteLine("2: Count by 3's up to 999");
            Console.WriteLine();

            for (int lWarm = 3; lWarm <= 999; lWarm += 3)

            {
                Console.WriteLine($"{lWarm}");
            }

            Console.WriteLine();
            Console.WriteLine();


            //Write a method to accept two integers as parameters and check whether they are equal or not.
            Console.WriteLine("3: Compare Inputs");
            Console.WriteLine();

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

            Console.WriteLine();
            Console.WriteLine();


            //Write a method to check whether a given number is even or odd.
            Console.WriteLine("4: Evens or Odds");
            Console.WriteLine();

            Console.WriteLine("Enter a number");
            int OE = int.Parse(Console.ReadLine());

            if (OE % 2 == 0)
            {
                Console.WriteLine($"{OE} is an Even number");
            }

            else
            {
                Console.WriteLine($"{OE} is an Odd number");
            }


            Console.WriteLine();
            Console.WriteLine();


            //Write a method to check whether a given number is positive or negative.
            Console.WriteLine("5: + or -");
            Console.WriteLine();

            Console.WriteLine("Enter any number with either a positive or a negative value");
            int test = int.Parse(Console.ReadLine());

            if (test >= 0)
            {
                Console.WriteLine($"{test} is positive");
            }

            else
            {
                Console.WriteLine($"{test} is negative");
            }

            Console.WriteLine();
            Console.WriteLine();

            //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!
            Console.WriteLine("6: Are You Old Enough To Vote?");
            Console.WriteLine();

            Console.WriteLine("How Old Are You?");
            int voter = int.Parse(Console.ReadLine());

            if (voter >= 21)
            {
                Console.WriteLine("Looks like you are able to Vote and maybe get a drink after words.");
            }

            else
            {
                Console.WriteLine("Sorry, but you're not old enough to vote.");
            }

        }
    }
}