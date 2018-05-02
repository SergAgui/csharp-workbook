using System;

namespace TicTacToe
{
    class Program
    {
        public static int turn = 0;
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                turn++;
                DrawBoard();
                CheckForWin();
                CheckForTie();
                GetInput();

            } while (!CheckForWin() && !CheckForTie());
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
            board[row][column] = playerTurn;
            playerTurn = (playerTurn == "X") ? "O" : "X";
            
        }
        public static bool CheckForWin()
        {
            return HorizontalWin() || VerticalWin() || DiagonalWin();
            // Console.WriteLine("Player " + playerTurn + "Wins!!");
        }

        public static bool CheckForTie()
        {
            if (turn == 8)
            {
                Console.WriteLine("Tie Game");
            }
            return false;
        }
        
        public static bool HorizontalWin()
        {
            if ((board[0][0] == playerTurn && board[0][1] == playerTurn && board[0][2] == playerTurn) ||
            (board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn) ||
            (board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn))
            {
                Console.WriteLine("Player " + playerTurn + " Wins!!");
                return true;
            }
            return false;
        }

        public static bool VerticalWin()
        {
            if((board[0][0] == playerTurn && board[1][0] == playerTurn && board[2][0] == playerTurn) ||
            (board[0][1] == playerTurn && board[1][1] == playerTurn && board[2][1] == playerTurn) ||
            (board[0][2] == playerTurn && board[1][2] == playerTurn && board[2][2] == playerTurn))
            {
                Console.WriteLine("Player " + playerTurn + " Wins!!");
                return true;
            }
            return false;
        }

        public static bool DiagonalWin()
        {
            if((board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2] == playerTurn) ||
            (board[0][2] == playerTurn && board[1][1] == playerTurn && board[2][0] == playerTurn))
            {
                Console.WriteLine("Player " + playerTurn + " Wins!!");
                return true;
            }
            return false;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}
