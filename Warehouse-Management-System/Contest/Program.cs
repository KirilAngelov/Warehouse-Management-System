using System;

namespace Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            Board test = new Board();
            test.EnterShips();
            test.printBoard();
            Board test2 = new Board();
            test2.EnterShips();
            test2.printBoard();
            Player playerOne = new Player();
            playerOne.board = test;

            Player playerTwo = new Player();
            playerTwo.board = test2;

            playerOne.GetEnemyBoard(playerTwo);

            playerOne.Attack(playerOne.fireBoard);
            playerTwo.board.printFireBoard();
        }
    }
}
