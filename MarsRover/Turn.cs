using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Turn
    {

        List<string> Direction = new List<string>() { "north", "northeast", "east", "southeast", "south", "southwest", "west", "northwest" };

        public void PerformTurn(RoverPosition position, char key)
        {
            switch(key)
            {
                case 'R':
                    position.RoverDirection = Direction[((Direction.IndexOf(position.RoverDirection) + 1) % 8)];
                    break;
                case 'L':
                    position.RoverDirection = Direction[((Direction.IndexOf(position.RoverDirection) + 7) % 8)];
                    break;


            }

            
        }

        //private void TurnLeft(RoverPosition position)
        //{
        //    position.RoverDirection = Direction[((Direction.IndexOf(position.RoverDirection) + 7) % 8)];
        //}
    }
}
