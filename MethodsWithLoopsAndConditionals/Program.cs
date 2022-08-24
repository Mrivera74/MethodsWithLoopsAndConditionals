using System.Collections.Generic;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that will print to the console all numbers 1000 through - 1000.
            Console.WriteLine("1: Count from 1000 to -1000");
            Console.WriteLine();

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine();
            Console.WriteLine();


            //Write a method that will print to the console numbers 3 through 999 by 3 each time.
            Console.WriteLine("2: Count by 3's up to 999");
            Console.WriteLine();

            for (int i = 1; i <= 333; i++)

            {
                Console.WriteLine($"{i * 3}");
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
            int uneven = int.Parse(Console.ReadLine());

            if (uneven % 2 == 0)
            {
                Console.WriteLine($"{uneven} is an Even number");
            }

            else
            {
                Console.WriteLine($"{uneven} is an Odd number");
            }


            Console.WriteLine();
            Console.WriteLine();


            //Write a method to check whether a given number is positive or negative.
            Console.WriteLine("5: + or -");
            Console.WriteLine();

            Console.WriteLine("Enter any number with either a positive or a negative value");
            int integers = int.Parse(Console.ReadLine());

            if (integers >= 0)
            {
                Console.WriteLine($"{integers} is positive");
            }

            else
            {
                Console.WriteLine($"{integers} is negative");
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

            Console.WriteLine();

            Console.WriteLine("Heating Up!");

            //Write a method to check if an integer(from the user) is in the range -10 to 10.
            Console.WriteLine("1: Are you in range?");
            Console.WriteLine();

            Console.WriteLine("Enter a Number:");
            int range = int.Parse(Console.ReadLine());


            if (range > -11 && range < 11)
            {
                Console.WriteLine($"{range} is in the Range we had in mind");
            }
                       
            else
            {
                Console.WriteLine($"{range} is not in the Range we had in mind");
            }

            Console.WriteLine();

            //Write a method to display the multiplication table(from 1 to 12) of a given integer.
            Console.WriteLine("2:Multiplication table");

            Console.WriteLine("Enter the number that you would like to see the multiples of:");
            int multi = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{multi} * {i} = {i * multi}");
            }


        }
    }
}