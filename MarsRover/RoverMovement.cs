using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
   public class RoverMovement 
    {
        private Turn turn = new Turn();
        private Move move = new Move();

        public void PerformAction(char key, RoverPosition position)
        {
            if (key == 'L' || key == 'R') turn.PerformTurn(position, key);
            else if (key == 'M') move.MoveForward(position);
        }

      
    }
}
