using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class RoverFinalCoordinate
    {
        public string GetFinalCoordinate(RoverPosition position)
        {
            return $"{position.XCurrent} {position.YCurrent} {position.RoverDirection}";
        }
    }
}
