using System;
using System.Collections.Generic;
using System.Text;

namespace Contest
{
  public class Player
  {
        public Board board { get; set; }
        public FireBoard fireBoard { get; set; }

        public void Attack(Board board)
        {
            Console.WriteLine("Please enter X Coordinate");
            int xCoordinate = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Y Coordinate");
            int yCoordinate = int.Parse(Console.ReadLine());
            while(xCoordinate<1 || xCoordinate > board.size) //validates X
            {
                Console.WriteLine("X is out of range,please reenter");
                xCoordinate = int.Parse(Console.ReadLine());
            }
            while (yCoordinate < 1 || yCoordinate > board.size) //validates Y
            {
                Console.WriteLine("Y is out of range,please reenter");
                yCoordinate = int.Parse(Console.ReadLine());
            }
            if (board.cells[(xCoordinate-1)*10+yCoordinate-1].isHit) //validates not hit
            {
                Console.WriteLine("The cell is already hit!");
                Console.WriteLine("Please reenter X");
                xCoordinate = int.Parse(Console.ReadLine());
                Console.WriteLine("Please reenter Y");
                yCoordinate = int.Parse(Console.ReadLine());
            }
            //if is not hit and is not empty
            if(!board.cells[(xCoordinate - 1) * 10 + yCoordinate-1].isHit && 
                !board.cells[(xCoordinate - 1) * 10 + yCoordinate - 1].IsEmpty)
            {
                Console.WriteLine("Hit");
                board.cells[(xCoordinate - 1) * 10 + yCoordinate - 1].isHit = true;
            }
            //if is not hit and IS empty
            if(!board.cells[(xCoordinate - 1) * 10 + yCoordinate - 1].isHit &&
                board.cells[(xCoordinate - 1) * 10 + yCoordinate - 1].IsEmpty)
            {
                Console.WriteLine("Miss");
                board.cells[(xCoordinate - 1) * 10 + yCoordinate - 1].isHit = true;
            }

        }

    }
}
