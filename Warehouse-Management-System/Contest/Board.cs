using System;
using System.Collections.Generic;
using System.Text;

namespace Contest
{
  public class Board
    {
        public List<Cell> cells { get; set; }
        public int size { get; set; } = 10;
        public Board()
        {
            cells = new List<Cell>();
            for (int i = 1; i <= size; i++)
            {
                for (int j= 1; j<=size ;j++)
                {
                    cells.Add(new Cell(i, j));
                }
            }
        }
        
        public void printBoard()
        {
           
            int counter = 0;
            for (int i = 0; i < 100; i++)
            {
                if (cells[i].IsEmpty)
                {
                    cells[i].printCell();
                    counter++;
                }
                if (!cells[i].IsEmpty && cells[i].isHit==false)
                {
                    Console.Write("[S]"); ;
                    counter++;

                }
                if (!cells[i].IsEmpty && cells[i].isHit == true)
                {
                    Console.Write("[X]"); ;
                    counter++;

                }

                if (counter == 10)
                {
                    Console.WriteLine();
                    counter = 0;
                }


            }

        }
        public void printFireBoard()
        {
            int counter = 0;
            for (int i = 0; i < cells.Count; i++)
            {


                cells[i].printCell();
                counter++;
                if (counter == 10)
                {
                    Console.WriteLine();
                    counter = 0;
                }

            }
        }
        public void EnterShips()
        {
            Console.WriteLine("Now enter coordinates of first ship-length ->3");
            Console.WriteLine("The ships are always placed horizontally");
            Console.WriteLine("We assume you place valid params-y is 1-8,x is 1-10 ");
            //Console.WriteLine("Enter either col for up-down placement or row for left-right placement");
            //string direction = Console.ReadLine();

            Console.WriteLine("Enter X");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Y");
            int y = int.Parse(Console.ReadLine());

            for (int i = (x-1)*10+y-1; i <= (x - 1) * 10 + y - 1+2; i++)
            {
                cells[i].IsEmpty = false;
            }
            Console.WriteLine("Enter next ship length 3");

            Console.WriteLine("Enter X");
             x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Y");
             y = int.Parse(Console.ReadLine());

            for (int i = (x - 1) * 10 + y - 1; i <= (x - 1) * 10 + y - 1 + 2; i++)
            {
                cells[i].IsEmpty = false;
            }
            Console.WriteLine("Place next ship length 4");
            Console.WriteLine("Enter X");
             x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Y");
             y = int.Parse(Console.ReadLine());

            for (int i = (x - 1) * 10 + y - 1; i <= (x - 1) * 10 + y - 1 + 3; i++)
            {
                cells[i].IsEmpty = false;
            }
        }

    }
}
