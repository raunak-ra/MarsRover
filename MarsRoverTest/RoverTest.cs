using System;
using Xunit;
using MarsRover;
namespace MarsRoverTest
{
   
    public class RoverTest
    {
        private RoverLocationDetails position;

        [Fact]
        public void Testing_For_Direction()
        {
            position = new RoverLocationDetails(1, 1, 10, 10, "north");
            Assert.Equal("north", position.RoverDirection);
        }

     
        [Fact]
        public void Forward_Testing()
        {
            position = new RoverLocationDetails(1,1,10,10,"north");
           
            string command = "FFFFF";
            
            foreach (var key in command)
            {
                IRoverAction action = RoverAction.DoAction(key);
                action.PerformAction(position);

            }
            
            RoverFinalCoordinate mars = new RoverFinalCoordinate();
            Assert.Equal("1 6 north", mars.GetFinalCoordinate(position));
        }

        [Fact]
        public void Testing_For_Left()
        {
            position = new RoverLocationDetails(1, 1, 10, 10, "north");

            string command = "L";
            foreach (var key in command)
            {
                IRoverAction action = RoverAction.DoAction(key);
                action.PerformAction(position);
            }

            RoverFinalCoordinate mars = new RoverFinalCoordinate();
            Assert.Equal("1 1 northwest", mars.GetFinalCoordinate(position));
        }

        [Fact]
        public void Testing_For_Right()
        {
            position = new RoverLocationDetails(1, 1, 10, 10, "north");
            position.XLower = 0; position.XUpper = 10;
            position.YLower = 0; position.YUpper = 10;
            string command = "RR";
            foreach (var key in command)
            {
                IRoverAction action = RoverAction.DoAction(key);
                action.PerformAction(position);
            }

            RoverFinalCoordinate mars = new RoverFinalCoordinate();
            Assert.Equal("1 1 east", mars.GetFinalCoordinate(position));
        }

        [Fact]
        public void Testing_For_Boundary()
        {
            position = new RoverLocationDetails(10, 10, 10, 10, "north");

            string command = "FFFFF";
           
            foreach (var key in command)
            {
                IRoverAction action = RoverAction.DoAction(key);
                action.PerformAction(position);
            }

            RoverFinalCoordinate mars = new RoverFinalCoordinate();
            Assert.Equal("10 10 north", mars.GetFinalCoordinate(position));
        }
        [Fact]
        public void Testing_For_Misc_Command1()
        {
            position = new RoverLocationDetails(1, 1, 10, 10, "east");

            string command = "FLLFR";
            
            foreach (var key in command)
            {           
                IRoverAction action = RoverAction.DoAction(key);
                action.PerformAction(position);
            }

            RoverFinalCoordinate mars = new RoverFinalCoordinate();
            Assert.Equal("2 2 northeast", mars.GetFinalCoordinate(position));
        }

        [Fact]
        public void Testing_For_Misc_Command2()
        {
            position = new RoverLocationDetails(1, 2, 5, 5, "north");

            string command = "LFLFLFLFF";
            
            foreach (var key in command)
            {
                IRoverAction action = RoverAction.DoAction(key);
                action.PerformAction(position);
            }

            RoverFinalCoordinate mars = new RoverFinalCoordinate();
            Assert.Equal("0 1 south", mars.GetFinalCoordinate(position));
        }

        [Fact]
        public void Testing_For_Misc_Command3()
        {
            position = new RoverLocationDetails(3, 3, 5, 5, "east");

            string command = "FFRFFRFRRF";
           
            foreach (var key in command)
            {
                IRoverAction action = RoverAction.DoAction(key);
                action.PerformAction(position);

            }

            RoverFinalCoordinate mars = new RoverFinalCoordinate();
            Assert.Equal("4 2 west", mars.GetFinalCoordinate(position));
        }
    }
}
