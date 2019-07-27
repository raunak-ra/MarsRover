using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class RoverLocationDetails
    {
        public int XCurrent, YCurrent, XLower=0, YLower=0, XUpper, YUpper;
        //public int YCurrent { get; set; }
        //public int XLower { get; set; }
        //public int YLower { get; set; }
        //public int XUpper { get; set; }
        //public int YUpper { get; set; }
        public string RoverDirection; /*{ get; set; }*/

        public RoverLocationDetails(int xcurrent, int ycurrent, int xupper, int yupper, string direction)
        {
            XCurrent = xcurrent;
            YCurrent = ycurrent;
            XUpper = xupper;
            YUpper = yupper;
            RoverDirection = direction;
        }
       
    }
}
