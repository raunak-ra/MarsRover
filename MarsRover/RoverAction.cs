using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
   public class RoverAction 
    {
        private Rotator turn = new Rotator();
        private RoverMovement move = new RoverMovement();

        public void PerformAction(char key, RoverLocationDetails position)
        {
            if (key == 'L' || key == 'R') turn.Rotate(position, key);
            else if (key == 'F') move.MoveForward(position);
        }

      
    }
}
