using System;

namespace Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            FireBoard test = new FireBoard();
            test.printBoard();
            Player player = new Player();
            player.Attack(test);
            Console.WriteLine();
            test.printBoard();
            
        }
    }
}
