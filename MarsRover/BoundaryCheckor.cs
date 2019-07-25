using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class BoundaryCheckor
    {
        public bool CheckBoundary(RoverPosition position)
        {
            switch (position.RoverDirection)
            {
                case "north": return (position.YUpper > position.YCurrent);
                case "south": return (position.YLower < position.YCurrent);
                case "east": return (position.XUpper > position.XCurrent);
                case "west": return (position.XLower < position.XCurrent);
                case "northeast": return (position.YUpper > position.YCurrent) && (position.XUpper > position.XCurrent);
                case "northwest": return (position.YUpper > position.YCurrent) && (position.XLower < position.XCurrent);
                case "southeast": return (position.YLower < position.YCurrent) && (position.XUpper > position.XCurrent);
                case "southwest": return (position.YLower < position.YCurrent) && (position.XLower < position.XCurrent);
                default: return false;
            }
            
        }
    }
}
