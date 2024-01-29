using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4x4.Models
{
    public class Movement
    {

        public void MoveForward(ObjectPosition position, int width, int height)
        {
            switch (position.CurrentDirection)
            {
                case Direction.N:
                    position.Y--;
                    break;
                case Direction.E:
                    position.X++;
                    break;
                case Direction.S:
                    position.Y++;
                    break;
                case Direction.W:
                    position.X--;
                    break;
            }
        }

        public void MoveBackward(ObjectPosition position, int width, int height)
        {
            switch (position.CurrentDirection)
            {
                case Direction.N:
                    position.Y++;
                    break;
                case Direction.E:
                    position.X--;
                    break;
                case Direction.S:
                    position.Y--;
                    break;
                case Direction.W:
                    position.X++;
                    break;
            }
        }

        public void TurnRight(ObjectPosition position)
        {
            // Turn 90 degrees to the right
            position.CurrentDirection = (Direction)(((int)position.CurrentDirection + 1) % 4);
        }

        public void TurnLeft(ObjectPosition position)
        {
            // Turn 90 degrees to the left
            position.CurrentDirection = (Direction)(((int)position.CurrentDirection + 3) % 4);
        }
        
    }
}
