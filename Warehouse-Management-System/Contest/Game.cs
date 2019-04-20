using System;
using System.Collections.Generic;
using System.Text;

namespace Contest
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Game()
        {
            Player1 = new Player();
            Player1.board.EnterShips();
            Player2 = new Player();
            Player2.board.EnterShips();
            Player1.GetEnemyBoard(Player2);
            Player2.GetEnemyBoard(Player1);
        }
        public void StartGame()
        {
            bool playerOneTurn = true;
            while (true)
            {
                
                if (Player1.Lives == 0)
                {
                    Console.WriteLine("Player 1 Wins!");
                    break;
                }
                if (Player2.Lives==0)
                {
                    Console.WriteLine("Player 2 Wins!");
                    break;
                }
                if (playerOneTurn)
                {
                    
                    Console.WriteLine("Your board");
                    Player1.board.printBoard();
                    Console.WriteLine();
                    Console.WriteLine("Enemy board");
                    Player1.fireBoard.printFireBoard();

                    if (Player1.Attack(Player2.board)!="Hit")
                    {
                        //Player1.Attack(Player2.board);
                        playerOneTurn = !playerOneTurn;
                    }
                        
                }
                if (!playerOneTurn)
                {
                    playerOneTurn = true;
                    Console.WriteLine("Your board");
                    Player2.board.printBoard();
                    Console.WriteLine();
                    Console.WriteLine("Enemy board");
                    Player2.fireBoard.printFireBoard();
                    if (Player2.Attack(Player1.board)!="Hit")
                    {
                        //Player2.Attack(Player1.board);
                        playerOneTurn = true;
                    }

                }
            }
        }

    }
}
