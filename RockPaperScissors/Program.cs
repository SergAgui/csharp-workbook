﻿using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter hand 2:");
            string hand2 = Console.ReadLine().ToLower();
            Console.WriteLine(CompareHands(hand1, hand2));

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
            if (hand1 == hand2)
            {
                return "It's a tie!";
            }

            if (hand1 == "rock")
            {
                if (hand2 == "scissors")
                {
                    return "Hand one wins!";
                }
                if (hand2 == "paper")
                {
                    return "Hand two wins!";
                }
            }

            if (hand1 == "paper")
            {
                if (hand2 == "scissors")
                {
                    return "Hand two wins";
                }
                if (hand2 == "rock")
                {
                    return "Hand one wins";
                }
            }
            if (hand1 == "scissors")
            {
                if (hand2 == "paper")
                {
                    return "Hand one wins";
                }
                if (hand2 == "rock")
                {
                    return "Hand two wins";
                }
            }
           return "";
        }
    }
}
