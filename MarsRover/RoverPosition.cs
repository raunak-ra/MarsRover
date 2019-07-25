using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class RoverPosition
    {
        public int XCurrent { get; set; }
        public int YCurrent { get; set; }
        public int XLower { get; set; }
        public int YLower { get; set; }
        public int XUpper { get; set; }
        public int YUpper { get; set; }
        public string RoverDirection { get; set; }

        public RoverPosition(int x, int y, string dirN)
        {
            XCurrent = x;
            YCurrent = y;
            RoverDirection = dirN;
        }
       
    }
}
