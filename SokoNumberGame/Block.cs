using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokoNumberGame
{
    internal enum blockName
        {
            Wall,
            Empty,
            Num,
            NumGoal
        };
    class Block
    {

        private blockName name;
        private int number;

        public blockName Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public void SetWall()
        {
            this.name = blockName.Wall;
            this.number = 0;
        }
        public void SetEmpty()
        {
            this.name = blockName.Empty;
            this.number = 0;
        }
        public void SetNum(int number)
        {
            this.name = blockName.Num;
            this.number = number;
        }
        public void SetNumGoal(int number)
        {
            this.name = blockName.NumGoal;
            this.number = number;
        }
        
    }
}
