﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Contest
{
    public class Cell
    {
        public bool IsEmpty { get; set; }
        public bool HasShip { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
            IsEmpty = true;

        }
    }
}
