using System;
using static System.Console;
using System.Collections.Generic;
using Test4x4.Models;

namespace Test4x4
{
    class Program
    {
        static List<ObjectPosition> visitedPositions = new List<ObjectPosition>();
        static Movement movement = new Movement();
        static void LogPosition(ObjectPosition position)
        {
            visitedPositions.Add(new ObjectPosition(position.X, position.Y));
        }
        static void Main()
        {
            try
            {
                // WriteLine("Enter the width, height, and initial position (comma-separated):");
                string[] headerParts = ReadLine().Split(',');

                int width = int.Parse(headerParts[0]);
                int height = int.Parse(headerParts[1]);
                int initialX = int.Parse(headerParts[2]);
                int initialY = int.Parse(headerParts[3]);

                // Check if initial position is within the matrix boundaries
                if (initialX < 0 || initialX >= width || initialY < 0 || initialY >= height)
                {
                    throw new InvalidOperationException("Initial position is outside the matrix boundaries.");
                }
                
                // Initialize object position with north direction
                ObjectPosition objectPosition = new ObjectPosition(initialX, initialY, Direction.N);

                // Read a comma-separated string of commands (1 to 4)
                string commandsString = ReadLine();
                int[] commands = Array.ConvertAll(commandsString.Split(','), int.Parse);
                ObjectPosition lastPosition = null;

                foreach (int command in commands)
                {
                    // Save every move to confirm if the object was OOB
                    ObjectPosition currentPosition = new ObjectPosition(objectPosition.X, objectPosition.Y);
                    visitedPositions.Add(currentPosition);

                    switch (command)
                    {
                        case 0:
                            // Exit, check OutOfBounds and print final positions
                            lastPosition = WasEverOutOfBounds(width, height);
                            if (lastPosition !=null)
                            {
                                WriteLine("[-1,-1]");
                            }
                            else
                            {
                                WriteLine($"[{objectPosition.X}, {objectPosition.Y}]");
                            }
                            return;

                        case 1:
                            // Move forward
                            movement.MoveForward(objectPosition, width, height);
                            LogPosition(objectPosition);
                            break;

                        case 2:
                            // Move backward
                            movement.MoveBackward(objectPosition, width, height);
                            LogPosition(objectPosition);
                            break;

                        case 3:
                            // Turn 90 degrees to the right
                            movement.TurnRight(objectPosition);
                            break;

                        case 4:
                            // Turn 90 degrees to the left
                            movement.TurnLeft(objectPosition);
                            break;

                        default:
                            WriteLine("[-1,-1]");
                            return;
                    }
                }
            }
            catch (Exception ex)
            {
                // Exception occurred
                WriteLine("[-1,-1]");
            }

        }
        static ObjectPosition WasEverOutOfBounds(int width, int height)
        {
            foreach (var position in visitedPositions)
            {
                if (position.X < 0 || position.X >= width || position.Y < 0 || position.Y >= height)
                {
                    return position; 
                }
            }
            return null; // Object was held within bounds
        }
    }

}