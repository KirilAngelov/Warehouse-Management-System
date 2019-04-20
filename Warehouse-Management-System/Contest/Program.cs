using System;

namespace Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            Board test = new Board();
            test.printBoard();
            Player player = new Player();
            player.Attack(test);
            Console.WriteLine();
            test.printBoard();
            
        }
    }
}
