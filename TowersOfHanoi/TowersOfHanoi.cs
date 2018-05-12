using System;
using System.Collections;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main()
        {
            Block block1 = new Block(1);
            Block block2 = new Block(2);
            Block block3 = new Block(3);
            Block block4 = new Block(4);
            Game game = new Game(); // is this right??
        }
    }

    class Game
    {
        public Tower[] towers {get; private set;}
        Dictionary<string, string[]> A = new Dictionary<string, string[]>();
        Dictionary<string, string[]> B = new Dictionary<string, string[]>();
        Dictionary<string, string[]> C = new Dictionary<string, string[]>();
    }

    class Tower
    {
        private Block[] blocks { get; set; }
        private Stack myStack = new Stack();
        public void PushBlock()
        {
            //something to add a block to a stack
            myStack.Push(blocks);
            foreach (var remaining in myStack)
            {
                Console.WriteLine(remaining);
            }
        
        }
            
        //something to take the block off a stack
        public void PullBlock()
        {
            myStack.Pop();
            foreach (var remaining in myStack)
            {
                Console.WriteLine(remaining);
            }
        }

        
    }

    class Block
    {
        public Block (int weight)
        {
            this.Weight = weight;
        }
        public int Weight {get; private set;}
    }
}
