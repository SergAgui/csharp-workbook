using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird blueJay = new Bird();
            NonFlyingBirds penguin = new NonFlyingBirds();
            Console.WriteLine("Hello World!");
        }
    }
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Nom nom nom");
        }
        public void breathe()
        {
            Console.WriteLine("Breathe in, breathe out");
        }
    }

    class Vertebrate : Animal
    {
        public bool backbone = true;
    }
    class Invertebrate : Animal
    {
        public bool backbone = false;
    }
    class Bird : Vertebrate
    {
        public bool feathers = true;
        public virtual void fly()
        {
            Console.WriteLine("Flap, flap, flap");
        }
    }
    class NonFlyingBirds : Bird
    {
        public override void fly()
        {
            Console.WriteLine("No dice.");
        }
    }
}
