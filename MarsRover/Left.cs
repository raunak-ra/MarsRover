using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Left : IRoverAction
    {

        Dictionary<string, int> DirectionValue = new Dictionary<string, int>()
        {
            { "north", 0} , {"northeast",1 }, {"east", 2 }, {"southeast", 3 }, {"south", 4 },{"southwest", 5 }, {"west", 6 }, {"northwest",7 }
        };
        Dictionary<int, string> ValueDirection = new Dictionary<int, string>()
        {
            {0, "north"} , {1, "northeast"}, {2, "east"}, {3, "southeast"}, {4, "south"},{5, "southwest" }, {6, "west" }, {7, "northwest"}
        };

        public void PerformAction(RoverLocationDetails position)
        {
            position.RoverDirection = ValueDirection[(DirectionValue[position.RoverDirection] + 7) % 8];
        }

    }
}
