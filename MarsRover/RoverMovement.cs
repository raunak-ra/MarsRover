using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
   public class RoverMovement 
    {
        private Turn turn;
        private Move move;

        public void PerformAction(char key, RoverPosition position)
        {
            if (key == 'L' || key == 'R') turn.PerformTurn(position, key);
            else if (key == 'M') move.MoveForward(position);
        }

      
    }
}
