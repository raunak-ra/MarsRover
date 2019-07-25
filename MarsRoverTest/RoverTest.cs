using System;
using Xunit;
using MarsRover;
namespace MarsRoverTest
{
   
    public class RoverTest
    {
        private RoverPosition position;

        [Fact]
        public void Testing_For_Direction()
        {
            position = new RoverPosition(1, 1, "north");
            position.XLower = 0; position.XUpper = 10;
            position.YLower = 0; position.YUpper = 10;
            Assert.Equal("north", position.RoverDirection);
        }

     
        [Fact]
        public void Forward_Testing()
        {
            position = new RoverPosition(1,1,"north");
            position.XLower = 0; position.XUpper = 10;
            position.YLower = 0; position.YUpper = 10;
            string command = "FFFFF";
            RoverMovement obj = new RoverMovement();
            foreach (var key in command)
            {
                obj.PerformAction(key, position);
            }
            
            RoverFinalCoordinate mars = new RoverFinalCoordinate();
            Assert.Equal("1 6 north", mars.GetFinalCoordinate(position));
        }

        [Fact]
        public void Testing_For_Left()
        {
            position = new RoverPosition(1, 1, "north");
            position.XLower = 0; position.XUpper = 10;
            position.YLower = 0; position.YUpper = 10;
            string command = "L";
            RoverMovement obj = new RoverMovement();
            foreach (var key in command)
            {
                obj.PerformAction(key, position);
            }

            RoverFinalCoordinate mars = new RoverFinalCoordinate();
            Assert.Equal("1 1 northwest", mars.GetFinalCoordinate(position));
        }

        [Fact]
        public void Testing_For_Right()
        {
            position = new RoverPosition(1, 1, "north");
            position.XLower = 0; position.XUpper = 10;
            position.YLower = 0; position.YUpper = 10;
            string command = "RR";
            RoverMovement obj = new RoverMovement();
            foreach (var key in command)
            {
                obj.PerformAction(key, position);
            }

            RoverFinalCoordinate mars = new RoverFinalCoordinate();
            Assert.Equal("1 1 east", mars.GetFinalCoordinate(position));
        }

        [Fact]
        public void Testing_For_Boundary()
        {
            position = new RoverPosition(10, 10, "north");
            position.XLower = 0; position.XUpper = 10;
            position.YLower = 0; position.YUpper = 10;
            string command = "FFFFF";
            RoverMovement obj = new RoverMovement();
            foreach (var key in command)
            {
                obj.PerformAction(key, position);
            }

            RoverFinalCoordinate mars = new RoverFinalCoordinate();
            Assert.Equal("10 10 north", mars.GetFinalCoordinate(position));
        }
        [Fact]
        public void Testing_For_Misc_Command1()
        {
            position = new RoverPosition(1, 1, "east")
            {
                XLower = 0,
                XUpper = 10,
                YLower = 0,
                YUpper = 10
            };
            string command = "FLLFR";
            RoverMovement obj = new RoverMovement();
            foreach (var key in command)
            {
                obj.PerformAction(key, position);
            }

            RoverFinalCoordinate mars = new RoverFinalCoordinate();
            Assert.Equal("2 2 northeast", mars.GetFinalCoordinate(position));
        }

        [Fact]
        public void Testing_For_Misc_Command2()
        {
            position = new RoverPosition(1, 2, "north");
            position.XLower = 0; position.XUpper = 5;
            position.YLower = 0; position.YUpper = 5;
            string command = "LFLFLFLFF";
            RoverMovement obj = new RoverMovement();
            foreach (var key in command)
            {
                obj.PerformAction(key, position);
            }

            RoverFinalCoordinate mars = new RoverFinalCoordinate();
            Assert.Equal("0 1 south", mars.GetFinalCoordinate(position));
        }

        [Fact]
        public void Testing_For_Misc_Command3()
        {
            position = new RoverPosition(3, 3, "east");
            position.XLower = 0; position.XUpper = 5;
            position.YLower = 0; position.YUpper = 5;
            string command = "FFRFFRFRRF";
            RoverMovement obj = new RoverMovement();
            foreach (var key in command)
            {
                obj.PerformAction(key, position);
            }

            RoverFinalCoordinate mars = new RoverFinalCoordinate();
            Assert.Equal("4 2 west", mars.GetFinalCoordinate(position));
        }
    }
}
