using System;

namespace RockPaperScissors
{
    class Program
    {
        public static int hand1Score = 0;
        public static int hand2Score = 0;
        public static void Main()
        {
            string[] plays = new [] {"rock", "paper", "scissors"};
            while (hand1Score < 5 && hand2Score < 5)
            {
                Console.WriteLine("Enter hand 1:");
                string hand1 = Console.ReadLine().ToLower();
                // Commented out to have a computer player 2
                // Console.WriteLine("Enter hand 2:");
                // string hand2 = Console.ReadLine().ToLower();
                Random rnd = new Random();
                int randomInt = rnd.Next(0, 3);
                string hand2 = plays[randomInt];
                Console.WriteLine("Hand 1 played {0} and Hand 2 played {1}", hand1, hand2);
                Console.WriteLine(CompareHands(hand1, hand2));
                Console.WriteLine("Hand 1 has {0} points and Hand 2 has {1} points", hand1Score, hand2Score);
            }
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
                    hand1Score++;
                    return "Hand one wins!";
                }
                if (hand2 == "paper")
                {
                    hand2Score++;
                    return "Hand two wins!";
                }
            }

            if (hand1 == "paper")
            {
                if (hand2 == "scissors")
                {
                    hand2Score++;
                    return "Hand two wins";
                }
                if (hand2 == "rock")
                {
                    hand1Score++;
                    return "Hand one wins";
                }
            }
            if (hand1 == "scissors")
            {
                if (hand2 == "paper")
                {
                    hand1Score++;
                    return "Hand one wins";
                }
                if (hand2 == "rock")
                {
                    hand2Score++;
                    return "Hand two wins";
                }
            }
           return "";
        }
    }
}
