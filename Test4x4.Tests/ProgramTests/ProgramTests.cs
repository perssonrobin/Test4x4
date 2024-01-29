using Xunit;
using Test4x4.Models;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Test4x4.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void ObjectPosition_DefaultDirection_ShouldBeNorth()
        {
            // Arrange
            int initialX = 0;
            int initialY = 0;

            // Act
            ObjectPosition objectPosition = new ObjectPosition(initialX, initialY);

            // Assert
            Assert.Equal(Direction.N, objectPosition.CurrentDirection);
        }
        [Fact]
        public void Move_West_ShouldDecreaseX()
        {
            // Arrange
            Movement movement = new Movement();
            ObjectPosition initialPosition = new ObjectPosition(3, 5, Direction.W);

            // Act
            movement.MoveForward(initialPosition, 10, 10);

            // Assert
            Assert.Equal(2, initialPosition.X);
        }
    }
}
