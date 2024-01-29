using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test4x4.Models;

namespace Test4x4.Models
{
    public class ObjectPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction CurrentDirection { get; set; }

        public ObjectPosition(int x, int y, Direction direction = Direction.N)
        {
            X = x;
            Y = y;
            CurrentDirection = direction;
        }
    }
}


