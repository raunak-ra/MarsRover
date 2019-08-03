using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Forward : IRoverAction
    {
        Dictionary<string,int> dictionaryX = new Dictionary<string, int>()
        {
            { "north", 0} , {"northeast",1 }, {"east", 1 }, {"southeast", 1 }, {"south", 0 },{"southwest", -1 }, {"west", -1 }, {"northwest",-1 }
        };
        Dictionary<string, int> dictionaryY = new Dictionary<string, int>()
        {
            { "north", 1} , {"northeast",1 }, {"east", 0 }, {"southeast", -1 }, {"south", -1 },{"southwest", -1 }, {"west", 0 }, {"northwest", 1 }
        };
      

        public void PerformAction(RoverLocationDetails roverLocationDetails)
        {
            
            BoundaryCheckor boundarycheckor = new BoundaryCheckor();
            if (boundarycheckor.CheckBoundary(roverLocationDetails))
            {

                roverLocationDetails.XCurrent += dictionaryX[roverLocationDetails.RoverDirection];
                roverLocationDetails.YCurrent += dictionaryY[roverLocationDetails.RoverDirection];

            }
        }
    }
}
