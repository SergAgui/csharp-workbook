using System;
using System.Threading;

namespace Game{
					
    public class Program
    {
        public static void Main()
        {
            int yn2 = 0;
            int yn3 = 0;
            int yn4 = 0;
            int yn5 = 0;
            int yn5_1 = 0;
            int stick = 0;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to the cavern of secrets!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Thread.Sleep(3000);

            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("It's a sharp looking stick with a point at one end. You decide to pick it up just in case.");
            Thread.Sleep(2000);
            Console.WriteLine("As you proceed further into the cave, you see a small glowing object");
            Console.WriteLine("Do you approach the object? [1 = Yes, 2 = No]");
            yn2 = Convert.ToInt32(Console.ReadLine());

            // APPROACH SHINY
            if (yn2 == 1)
            {
                Console.WriteLine("You approach the object...");
                Thread.Sleep(2000);
                Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                Thread.Sleep(1000);
                Console.WriteLine("The eye belongs to a giant spider! DUN DUN DUNNN!!!");
                Console.WriteLine("Do you try to fight it? [1 = Yes, 2 = No]");
                yn3 = Convert.ToInt32(Console.ReadLine());

                // FIGHT SPIDER W/ STICK
                if (yn3 == 1)
                {
                    Console.WriteLine("You only have a stick to fight with!");
                    Console.WriteLine("You quickly jab the spider in one of it's eye and gain an advantage");
                    Thread.Sleep(2000);
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("                Fightin' Time!!!                ");
                    Console.WriteLine("    MAKE YOUR HITS COUNT TO KILL THE SPIDER     ");
                    Console.WriteLine("  DON'T LET IT HIT YOU! TIME YOUR DODGES WELL!  ");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Thread.Sleep(2000);

                    Console.WriteLine("You've taken out one out eye... seven more to go.");
                    Console.WriteLine("The spider circles to your right and you notice that you took out the eye on it's far right.");
                    Console.WriteLine("You circle left and take a quick glance around an notice you are in a large room with web covered walls and boulders.");
                    Thread.Sleep(1500);

                    Console.WriteLine("The spider sees you take a glance around and jumps towards you!");
                    Console.WriteLine("Do you also attack or try to defend? 1 = ATTACK!!, 2 = DEFEND!!");
                    yn4 = Convert.ToInt32(Console.ReadLine());

                    if (yn4 == 1)
                    {
                        Console.WriteLine("As the spider lunges towards you, you take out another two eyes with one swipe of your stick!");
                        Console.WriteLine("Immediately catching it's balance, the spider launches itself towards you again!");
                        Console.WriteLine("Do you attack again or defend? 1 = ATTACK!, 2 = DEFEND!!");
                        yn5 = Convert.ToInt32(Console.ReadLine());

                        if (yn5 == 1)
                        {
                            Console.WriteLine("Sill semi recovering from the last attack, you lose your footing and fall backwards...");
                            Thread.Sleep(2000);
                            Console.WriteLine("As you hit the ground, you hold your stick out in front of you with both hands");
                            Thread.Sleep(1000);
                            Console.WriteLine("You open your eyes as you feel the stick break in half under the weight of the spider's head...");
                            Thread.Sleep(1000);
                            Console.WriteLine("Or so you thought... looking up, you see that your stick has gone straight through the spider's head!");
                            Console.WriteLine("You did it!!!!");
                            Thread.Sleep(2500);
                            Console.WriteLine("Congratulations!! You've defeted the spider!!!");
                            Console.WriteLine("You decide not to go poking around random caves for a while.");
                            Thread.Sleep(3000);
                            Console.WriteLine("END");
                        }
                        else if (yn5 >1)
                        {
                            Console.WriteLine("You circle left some and narrowly miss the spider's attack.");
                            Console.WriteLine("Sensing it's guard is down, you jump for the spider's head!!");
                            Thread.Sleep(1000);
                            Console.WriteLine("You pierce the spider's head with the sharp part of the stick to deliver the final blow!!");
                            Thread.Sleep(500);
                            Console.WriteLine("The spider falls to the ground and the room starts to shake...");
                            Console.WriteLine("Rocks start falling from the cieling and you realize that it's time to go.");
                            Thread.Sleep(500);
                            Console.WriteLine("Running as fast as you can, you make it out of the cave before it collapses.");
                            Thread.Sleep(2500);
                            Console.WriteLine("Congratulations!! You've defeted the spider!!!");
                            Console.WriteLine("You decide not to go poking around random caves for a while.");
                            Thread.Sleep(3000);
                            Console.WriteLine("END");
                        }
                    }
                    else if (yn4 > 1)
                    {
                        Console.WriteLine("As the spider lunges towards you, you circle left a little more and barely dodge the attack!");
                        Console.WriteLine("The spider staggers trying to catch it's balance, but you move in quick and stab it in the side!");
                        Thread.Sleep(2000);
                        Console.WriteLine("Backing off and collecting itself, the spider prepares for another attack.");
                        Console.WriteLine("Screeching in pain, the spider moves for an attack again.");
                        Console.WriteLine("Do you attack or defend? 1 = Attack, 2 = Defend");
                        yn5_1 = Convert.ToInt32(Console.ReadLine());

                        if (yn5_1 == 1)
                        {
                            Console.WriteLine("You move towards the spider, but notice that it trips and ends up sliding into you.");
                            Console.WriteLine("You get pushed all the way to the wall behind you and are pinned back by the spider.");
                            Thread.Sleep(2000);
                            Console.WriteLine("The room starts to shake as rocks fall from the cieling...");
                            Console.WriteLine("You try to move, but the spider's weight doesn't let you.");
                            Thread.Sleep(1000);
                            Console.WriteLine("Seeing the rocks fall, you close your eyes...");
                            Thread.Sleep(2000);
                            Console.WriteLine("End...");
                        }
                        else if (yn5_1 > 1)
                        {
                            Console.WriteLine("The spider rushes you, but trips and slides towards you.");
                            Console.WriteLine("You jump left and dodge the spider as it slams into a wall!");
                            Thread.Sleep(1000);
                            Console.WriteLine("Rocks start falling from the cieling and you realize that it's time to go.");
                            Thread.Sleep(500);
                            Console.WriteLine("Running as fast as you can, you make it out of the cave before it collapses.");
                            Thread.Sleep(2500);
                            Console.WriteLine("Congratulations!! You've escaped with your life!!!");
                            Console.WriteLine("You decide not to go poking around random caves for a while.");
                            Thread.Sleep(3000);
                            Console.WriteLine("END");
                        }
                    }
                }
                else if (yn3 > 1)
                {
                    Console.WriteLine("You choose not to fight the spider and make your way to the exit behind you.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Still feeling it's space threatened, it makes a move towards you with it's fangs!!!");
                    Thread.Sleep(1000);
                    Console.WriteLine("Not expecting the spider to attack, you fall backwards under the weight of the spider.");
                    Console.WriteLine("Your vision fades and you pass out...");
                    Thread.Sleep(3000);
                    Console.WriteLine("You wake up and find you can't move!!");
                    Console.WriteLine("Looking down you see that you are being wrapped in the spider's webbing!!!");
                    Console.WriteLine("You think to yourself that you should have been more prepared for an attack as your vision fades again...");
                    Thread.Sleep(2000);
                    Console.WriteLine("End...");
                }
            }

            else if (yn2 > 1)
            {
                Console.WriteLine("You'd rather be eating a delicious meal than exploring right now.");
                Console.WriteLine("You decide to come back later and leave the stick where you found it.");
                Thread.Sleep(2000);
                Console.WriteLine("END?");                
            }
        }
    }
}