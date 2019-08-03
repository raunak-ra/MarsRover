using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
   public class RoverAction 
    {

        public static IRoverAction DoAction(char key)
        {
            if (key == 'F') return new Forward();
            else if (key == 'L') return new Left();
            else if (key == 'R') return new Right();
            else return null;
        }
      
    }
}
