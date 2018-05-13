using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
        //1) count numbers between 1-100 are divisible by 3 with no remainder. Display to console
            // problemOne();
        //2) Continuously ask user to enter a number or "ok" to exit. Calc the sum of all numbers and display to console
            // problemTwo();
        //3) Ask user to enter a number, compute the factorial of the number and print to console.
		//		i.e. User>5, program calc's 5*4*3*2*1 and display as "5! = 120"
            // problemThree();
        //4) Program picks a random number between1-10, give user 4 chances to guess. If guessed, display "You won!", else, "You lost".
		//		Dislpay to console what the correct number was too
            // problemFour();
        //5) Ask user to enter a series of numbers separated by commas. Find biggest number and display to console.
		//		i.e. User>4,3,8,1,4.... program should display 8
        
            Console.WriteLine("Hello World!");
        }
        static void problemOne()
        {
            int total = 0;
            for (int i = 0; i < 100; i++)
            {
                if ( i % 3 == 0)
                {
                    total++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Total: {0}", total);
            return;
        }
        static void problemTwo()
        {
            string end = "ok";
            List<int> two = new List<int>();
            Console.WriteLine("Please enter a number: ");
            two.Add(Convert.ToInt32(Console.ReadLine()));
            while (true)
            {
                Console.WriteLine("Please enter another number or type 'ok' to end: ");
                if ( Console.ReadLine() == end )
                {
                    int done = two.Sum();
                    Console.WriteLine("The sum of the numbers entered is: " + done);
                    return;
                }
                else
                {
                    two.Add(Convert.ToInt32(Console.ReadLine()));
                }
            }
        }
        static void problemThree()
        {
            int number;
            int result;
            Console.WriteLine("Please enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            result = number;
            for (int i = number - 1; i >= 1; i--)
            {
                result = result * i;
            }
            Console.WriteLine("Factorial of your number is : " + result);
            return;
        }
        static void problemFour()
        {
            Random rnd = new Random();
            int key = rnd.Next(1, 10);
            Console.WriteLine("Guess a number between 1-10");
            for (int i = 1; i < 4; i++)
            {
                if(Convert.ToInt32(Console.ReadLine()) == key)
                {
                    Console.WriteLine("You Win!!");
                    return;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
            Console.WriteLine("You lose! The answer was " + key);
        }
        static void problemFive()
        {
            // yes
        }
    }
}
