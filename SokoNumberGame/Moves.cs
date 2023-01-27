using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokoNumberGame
{
    public class Moves
    {
        public bool up;
        public bool down;
        public bool right;
        public bool left;

        public Moves()
        {
            up = down = right = left = true;
        }
    }
}
