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
        Dictionary<string, int> dictionary = new Dictionary<string, int>()
        {
            { "north", 1 }, {"northeast",1 }, {"east", 1 }, {"southeast", 0 }, {"south", -1 },{"southwest", 1 }, {"west", -1 }, {"northwest",1 }
        };
        Dictionary<string,int> dictionaryX = new Dictionary<string, int>()
        {
            { "north", 0} , {"northeast",1 }, {"east", 1 }, {"southeast", -1 }, {"south", 0 },{"southwest", 1 }, {"west", -1 }, {"northwest",-1 }
        };
        Dictionary<string, int> dictionaryY = new Dictionary<string, int>()
        {
            { "north", 1} , {"northeast",1 }, {"east", 0 }, {"southeast", -1 }, {"south", -1 },{"southwest", -1 }, {"west", 0 }, {"northwest", 1 }
        };
        public void MoveForward(RoverPosition position)
        {
            BoundaryCheckor boundarycheckor = new BoundaryCheckor();
            if (boundarycheckor.CheckBoundary(position))
            {

                position.XCurrent += dictionaryX[position.RoverDirection];
                position.YCurrent += dictionaryY[position.RoverDirection];
                // dictionary[position.RoverDirection]
                //switch (position.RoverDirection)
                //{
                //    case "north":
                //        position.YCurrent += 1;
                //        break;
                //    case "south":
                //        position.YCurrent -= 1;
                //        break;
                //    case "east":
                //        position.XCurrent += 1;
                //        break;
                //    case "west":
                //        position.XCurrent -= 1;
                //        break;
                //    case "northeast":
                //        position.YCurrent += 1;
                //        position.XCurrent += 1;
                //        break;
                //    case "southwest":
                //        position.XCurrent -= 1;
                //        position.YCurrent -= 1;
                //        break;
                //    case "southeast":
                //        position.XCurrent += 1;
                //        position.YCurrent -= 1;
                //        break;
                //    case "northwest":
                //        position.XCurrent -= 1;
                //        position.YCurrent += 1;
                //        break;

            }

            }
            else
            {
                // DO NOT MOVE !!!!
            }
        }
        public void UpdatePosition(RoverPosition position)
        {
             
        }

    }
}
