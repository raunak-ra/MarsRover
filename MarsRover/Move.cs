using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Move
    {
        List<string> Direction = new List<string>() { "north", "northeast", "east", "southeast", "south", "southwest", "west", "northwest" };

        public void MoveForward(RoverPosition position)
        {
            BoundaryCheckor boundarycheckor = new BoundaryCheckor();
            if (boundarycheckor.CheckBoundary(position))
            {
                switch (position.RoverDirection)
                {
                    case "north":
                        position.YCurrent += 1;
                        break;
                    case "south":
                        position.YCurrent -= 1;
                        break;
                    case "east":
                        position.XCurrent += 1;
                        break;
                    case "west":
                        position.XCurrent -= 1;
                        break;
                    case "northeast":
                        position.YCurrent += 1;
                        position.XCurrent += 1;
                        break;
                    case "southwest":
                        position.XCurrent -= 1;
                        position.YCurrent -= 1;
                        break;
                    case "southeast":
                        position.XCurrent += 1;
                        position.YCurrent -= 1;
                        break;
                    case "northwest":
                        position.XCurrent -= 1;
                        position.YCurrent += 1;
                        break;

                }

            }
            else
            {
                // DO NOT MOVE !!!!
            }
        }

    }
}
