using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokoNumberGame
{

    public class Game
    {
        public int stage;
        public decimal speed;
        public Algorithm algorithm;
        public int width;
        public int hight;
        public int blockLength;
        public int spaceBetweenBlocks;

        public Game()
        {
            this.speed = 10;
            this.algorithm = Algorithm.UserPlay;
            this.stage = 1;
            this.width = 6;
            this.hight = 7;
            this.blockLength = 25;
            this.spaceBetweenBlocks = 10;
        }
       
    }
}
