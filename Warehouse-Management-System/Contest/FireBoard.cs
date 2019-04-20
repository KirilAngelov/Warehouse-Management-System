using System;
using System.Collections.Generic;
using System.Text;

namespace Contest
{
   public class FireBoard:Board
    {
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
    }
}
