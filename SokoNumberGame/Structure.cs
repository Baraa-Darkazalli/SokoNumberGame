using System;
using System.Collections.Generic;

namespace SokoNumberGame
{
    public class Structure : Game
    {
        //Atributes
        public Structure father;
        private Block[,] Array;
        public int numCount;
        public NumberBlock[] Num;
        public NumberBlock[] NumGoal;
        private int cost;
        private Dictionary<int, bool> board;
        public int Cost { set; get; }

        //Constructor
        public Structure()
        {
            Cost = 0;
            Array = new Block[this.width, this.hight];

        }

        //Create Space Methods
        public void clearArray()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < hight; j++)
                {
                    Array[i, j] = new Block();
                    Array[i, j].SetWall();

                }
            }
        }
        public void createStage1()
        {
            this.clearArray();
            numCount = 1;
            Num = new NumberBlock[numCount];
            NumGoal = new NumberBlock[numCount];
            Array[1, 1].SetNum(1);
            this.Num[0] = new NumberBlock();
            this.Num[0].x = 1;
            this.Num[0].y = 1;
            Array[1, 2].SetEmpty();
            Array[1, 3].SetEmpty();
            Array[1, 4].SetEmpty();
            Array[1, 5].SetNumGoal(1);
            this.NumGoal[0] = new NumberBlock();
            this.NumGoal[0].x = 1;
            this.NumGoal[0].y = 5;

           
        }
        public void createStage2()
        {
            this.clearArray();
            numCount = 2;
            Num = new NumberBlock[numCount];
            NumGoal = new NumberBlock[numCount];
            Array[1, 1].SetNum(1);
            this.Num[0] = new NumberBlock();
            this.Num[0].x = 1;
            this.Num[0].y = 1;
            Array[1, 3].SetNum(2);
            this.Num[1] = new NumberBlock();
            this.Num[1].x = 1;
            this.Num[1].y = 3;
            Array[2, 3].SetEmpty();
            Array[2, 1].SetEmpty();
            Array[3, 3].SetEmpty();
            Array[3, 1].SetEmpty();
            Array[4, 1].SetNumGoal(1);
            this.NumGoal[0] = new NumberBlock();
            this.NumGoal[0].x = 4;
            this.NumGoal[0].y = 1;
            Array[4, 3].SetNumGoal(2);
            this.NumGoal[1] = new NumberBlock();
            this.NumGoal[1].x = 4;
            this.NumGoal[1].y = 3;
        }
        public void createStage3()
        {
            this.clearArray();
            numCount = 2;
            Num = new NumberBlock[numCount];
            NumGoal = new NumberBlock[numCount];
            Array[1, 1].SetNum(1);
            this.Num[0] = new NumberBlock();
            this.Num[0].x = 1;
            this.Num[0].y = 1;
            Array[3, 3].SetNum(2);
            this.Num[1] = new NumberBlock();
            this.Num[1].x = 3;
            this.Num[1].y = 3;
            Array[1, 2].SetEmpty();
            Array[1, 3].SetEmpty();
            Array[2, 2].SetEmpty();
            Array[3, 1].SetEmpty();
            Array[3, 2].SetNumGoal(1);
            this.NumGoal[0] = new NumberBlock();
            this.NumGoal[0].x = 3;
            this.NumGoal[0].y = 2;
            Array[1, 2].SetNumGoal(2);
            this.NumGoal[1] = new NumberBlock();
            this.NumGoal[1].x = 1;
            this.NumGoal[1].y = 2;
        }
        public void createStage4()
        {
            this.clearArray();
            numCount = 3;
            Num = new NumberBlock[numCount];
            NumGoal = new NumberBlock[numCount];
            Array[1, 1].SetNum(1);
            this.Num[0] = new NumberBlock();
            this.Num[0].x = 1;
            this.Num[0].y = 1;
            Array[1, 3].SetNum(2);
            this.Num[1] = new NumberBlock();
            this.Num[1].x = 1;
            this.Num[1].y = 3;
            Array[1, 5].SetNum(3);
            this.Num[2] = new NumberBlock();
            this.Num[2].x = 1;
            this.Num[2].y = 5;
            Array[2, 2].SetEmpty();
            Array[2, 4].SetEmpty();
            Array[3, 3].SetEmpty();
            Array[2, 5].SetNumGoal(1);
            this.NumGoal[0] = new NumberBlock();
            this.NumGoal[0].x = 2;
            this.NumGoal[0].y = 5;
            Array[2, 3].SetNumGoal(2);
            this.NumGoal[1] = new NumberBlock();
            this.NumGoal[1].x = 2;
            this.NumGoal[1].y = 3;
            Array[2, 1].SetNumGoal(3);
            this.NumGoal[2] = new NumberBlock();
            this.NumGoal[2].x = 2;
            this.NumGoal[2].y = 1;
        }
        public void createStage5()
        {
            this.clearArray();
            numCount = 4;
            Num = new NumberBlock[numCount];
            NumGoal = new NumberBlock[numCount];
            Array[1, 1].SetNum(1);
            this.Num[0] = new NumberBlock();
            this.Num[0].x = 1;
            this.Num[0].y = 1;
            Array[2, 2].SetNum(2);
            this.Num[1] = new NumberBlock();
            this.Num[1].x = 2;
            this.Num[1].y = 2;
            Array[3, 3].SetNum(3);
            this.Num[2] = new NumberBlock();
            this.Num[2].x = 3;
            this.Num[2].y = 3;
            Array[4, 4].SetNum(4);
            this.Num[3] = new NumberBlock();
            this.Num[3].x = 4;
            this.Num[3].y = 4;
            Array[2, 4].SetEmpty();
            Array[3, 1].SetEmpty();
            Array[4, 1].SetEmpty();
            Array[4, 2].SetEmpty();
            Array[2, 1].SetNumGoal(1);
            this.NumGoal[0] = new NumberBlock();
            this.NumGoal[0].x = 2;
            this.NumGoal[0].y = 1;
            Array[3, 2].SetNumGoal(2);
            this.NumGoal[1] = new NumberBlock();
            this.NumGoal[1].x = 3;
            this.NumGoal[1].y = 2;
            Array[4, 3].SetNumGoal(3);
            this.NumGoal[2] = new NumberBlock();
            this.NumGoal[2].x = 4;
            this.NumGoal[2].y = 3;
            Array[3, 4].SetNumGoal(4);
            this.NumGoal[3] = new NumberBlock();
            this.NumGoal[3].x = 3;
            this.NumGoal[3].y = 4;
        }
        public void createStage6()
        {
            this.clearArray();
            numCount = 5;
            Num = new NumberBlock[numCount];
            NumGoal = new NumberBlock[numCount];
            Array[2, 2].SetNum(1);
            this.Num[0] = new NumberBlock();
            this.Num[0].x = 2;
            this.Num[0].y = 2;
            Array[1, 3].SetNum(2);
            this.Num[1] = new NumberBlock();
            this.Num[1].x = 1;
            this.Num[1].y = 3;
            Array[3, 1].SetNum(3);
            this.Num[2] = new NumberBlock();
            this.Num[2].x = 3;
            this.Num[2].y = 1;
            Array[3, 3].SetNum(4);
            this.Num[3] = new NumberBlock();
            this.Num[3].x = 3;
            this.Num[3].y = 3;
            Array[2, 4].SetNum(5);
            this.Num[4] = new NumberBlock();
            this.Num[4].x = 2;
            this.Num[4].y = 4;
            Array[1, 1].SetEmpty();
            Array[1, 2].SetEmpty();
            Array[2, 1].SetEmpty();
            Array[2, 3].SetNumGoal(1);
            this.NumGoal[0] = new NumberBlock();
            this.NumGoal[0].x = 2;
            this.NumGoal[0].y = 3;
            //Array[1, 3].SetNumGoal(2);
            this.NumGoal[1] = new NumberBlock();
            this.NumGoal[1].x = 1;
            this.NumGoal[1].y = 3;
            //Array[3, 3].SetNumGoal(3);
            this.NumGoal[2] = new NumberBlock();
            this.NumGoal[2].x = 3;
            this.NumGoal[2].y = 3;
            Array[3, 4].SetNumGoal(4);
            this.NumGoal[3] = new NumberBlock();
            this.NumGoal[3].x = 3;
            this.NumGoal[3].y = 4;
            //Array[2, 4].SetNumGoal(5);
            this.NumGoal[4] = new NumberBlock();
            this.NumGoal[4].x = 2;
            this.NumGoal[4].y = 4;
        }
        public void declareStage()
        {
            switch (this.stage)
            {
                case 1:
                    createStage1();
                    break;
                case 2:
                    createStage2();
                    break;
                case 3:
                    createStage3();
                    break;
                case 4:
                    createStage4();
                    break;
                case 5:
                    createStage5();
                    break;
                case 6:
                    createStage6();
                    break;
                default:
                    createStage1();
                    break;
            }
        }

        //Structure Methods
        public Moves[] checkMoves()
        {
            Moves[] moves = new Moves[this.numCount];
            for (int i = 0; i < this.numCount; i++)
            {
                moves[i] = new Moves();
                if (this.Num[i] != null)
                {
                    blockName top = this.Array[this.Num[i].x - 1, this.Num[i].y].Name;
                    if (top == blockName.Wall || top == blockName.Num)
                        moves[i].up = false;

                    blockName down = this.Array[this.Num[i].x + 1, this.Num[i].y].Name;
                    if (down == blockName.Wall || down == blockName.Num)
                        moves[i].down = false;

                    blockName left = this.Array[this.Num[i].x, this.Num[i].y - 1].Name;
                    if (left == blockName.Wall || left == blockName.Num)
                        moves[i].left = false;

                    blockName right = this.Array[this.Num[i].x, this.Num[i].y + 1].Name;
                    if (right == blockName.Wall || right == blockName.Num)
                        moves[i].right = false;

                }
            }

            return moves;
        }
        public void moveRight(Moves[] moves)
        {
            for (int i = 0; i < this.numCount; i++)
            {
                if (moves[i].right == true)
                {
                    this.Array[this.Num[i].x, this.Num[i].y + 1].SetNum(i + 1);
                    this.Array[this.Num[i].x, this.Num[i].y].SetEmpty();
                    for (int j = 0; j < this.numCount; j++)
                    {
                        if (this.Num[i].x == this.NumGoal[j].x && this.Num[i].y == this.NumGoal[j].y)
                        {
                            this.Array[this.Num[i].x, this.Num[i].y].SetNumGoal(j + 1);
                            break;
                        }
                    }
                    this.Num[i].y = this.Num[i].y + 1;
                }
            }
        }
        public void moveLeftBoard(Moves[] moves)
        {
            for (int i = 0; i < this.numCount; i++)
            {
                if (moves[i].left == true)
                {
                    board[((Num[i].x) * 10) + (Num[i].y)] = true;
                    board[((Num[i].x) * 10) + (Num[i].y - 1)] = false;

                    this.Num[i].y = this.Num[i].y - 1;
                }
            }
        }
        public void moveLeft(Moves[] moves)
        {
            for (int i = 0; i < this.numCount; i++)
            {
                if (moves[i].left == true)
                {
                    this.Array[this.Num[i].x, this.Num[i].y - 1].SetNum(i + 1);
                    this.Array[this.Num[i].x, this.Num[i].y].SetEmpty();
                    for (int j = 0; j < this.numCount; j++)
                    {
                        if (this.Num[i].x == this.NumGoal[j].x && this.Num[i].y == this.NumGoal[j].y)
                        {
                            this.Array[this.Num[i].x, this.Num[i].y].SetNumGoal(j + 1);
                            break;
                        }
                    }
                    this.Num[i].y = this.Num[i].y - 1;
                }
            }
        }
        public void moveUpBoard(Moves[] moves)
        {
            for (int i = 0; i < this.numCount; i++)
            {
                if (moves[i].up == true)
                {
                    board[((Num[i].x) * 10) + (Num[i].y)] = true;
                    board[((Num[i].x - 1) * 10) + (Num[i].y)] = false;

                    this.Num[i].x = this.Num[i].x - 1;
                }
            }
        }
        public void moveUp(Moves[] moves)
        {
            for (int i = 0; i < this.numCount; i++)
            {
                if (moves[i].up == true)
                {
                    this.Array[this.Num[i].x - 1, this.Num[i].y].SetNum(i + 1);
                    this.Array[this.Num[i].x, this.Num[i].y].SetEmpty();
                    for (int j = 0; j < this.numCount; j++)
                    {
                        if (this.Num[i].x == this.NumGoal[j].x && this.Num[i].y == this.NumGoal[j].y)
                        {
                            this.Array[this.Num[i].x, this.Num[i].y].SetNumGoal(j + 1);
                            break;
                        }
                    }
                    this.Num[i].x = this.Num[i].x - 1;
                }
            }
        }
        public void moveDownBoard(Moves[] moves)
        {
            for (int i = 0; i < this.numCount; i++)
            {
                if (moves[i].down == true)
                {
                    board[((Num[i].x) * 10) + (Num[i].y)] = true;
                    board[((Num[i].x + 1) * 10) + (Num[i].y)] = false;

                    this.Num[i].x = this.Num[i].x + 1;
                }
            }
        }
        public void moveDown(Moves[] moves)
        {
            for (int i = 0; i < this.numCount; i++)
            {
                if (moves[i].down == true)
                {
                    this.Array[this.Num[i].x + 1, this.Num[i].y].SetNum(i + 1);
                    this.Array[this.Num[i].x, this.Num[i].y].SetEmpty();
                    for (int j = 0; j < this.numCount; j++)
                    {
                        if (this.Num[i].x == this.NumGoal[j].x && this.Num[i].y == this.NumGoal[j].y)
                        {
                            this.Array[this.Num[i].x, this.Num[i].y].SetNumGoal(j + 1);
                            break;
                        }
                    }
                    this.Num[i].x = this.Num[i].x + 1;
                }
            }
        }

        public void print(Form1 form)
        {
            //foreach (Structure str in this.getNextStates())
            //{
            //    this.printArr(str);
            //    Console.WriteLine();
            //    //this.printArr(str.father);
            //}
            int x = 10;
            int y = 10;

            for (int i = 0; i < this.width; i++)
            {

                for (int j = 0; j < this.hight; j++)
                {
                    switch (this.Array[i, j].Name)
                    {
                        case blockName.Wall:
                            form.drawWall(x += this.blockLength + this.spaceBetweenBlocks, y);
                            break;
                        case blockName.Empty:
                            form.drawEmpty(x += this.blockLength + this.spaceBetweenBlocks, y);
                            break;
                        case blockName.Num:
                            form.drawNumber(this.Array[i, j].Number.ToString(), x += this.blockLength + this.spaceBetweenBlocks, y);
                            break;
                        case blockName.NumGoal:
                            form.drawNumberGoal(this.Array[i, j].Number.ToString(), x += this.blockLength + this.spaceBetweenBlocks, y);
                            break;
                        default:
                            form.drawWall(x += this.blockLength + this.spaceBetweenBlocks, y);
                            break;
                    }

                }
                y += this.blockLength + this.spaceBetweenBlocks;
                x = 10;
            }
        }
        public bool equals(Structure s, Structure s1)
        {
            if (s == null || s1==null) return false;
            else
            {
                for (int i = 0; i < s.numCount; i++)
                {
                    if (s.Num[i].x != s1.Num[i].x || s.Num[i].y != s1.Num[i].y || s.NumGoal[i].x != s1.NumGoal[i].x || s.NumGoal[i].y != s1.NumGoal[i].y)
                        return false;
                }

                return true;
            }
        }
        public void printArr()
        {
            for (int i = 0; i < this.width; i++)
            {
                for (int j = 0; j < this.hight; j++)
                {

                    Console.Write(this.Array[i, j].Name);
                    if (this.Array[i, j].Name == blockName.Num) Console.Write(this.Array[i, j].Number);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public bool isFinal()
        {
            for (int i = 0; i < this.numCount; i++)
            {
                if (this.Num[i].x != this.NumGoal[i].x || this.Num[i].y != this.NumGoal[i].y)
                    return false;
            }
            return true;
        }
        public List<Structure> getNextStates()
        {
            List<Structure> nextStates = new List<Structure>();
            Moves[] moves = this.checkMoves();

            //Up
            Structure structureCopy = this.DeepCopy();
            structureCopy.moveUp(moves);
            if (this.equals(structureCopy, this) == false)
                nextStates.Add(structureCopy);

            //Down
            structureCopy = this.DeepCopy();
            structureCopy.moveDown(moves);
            if (this.equals(structureCopy, this) == false)
                nextStates.Add(structureCopy);

            //Right
            structureCopy = this.DeepCopy();
            structureCopy.moveRight(moves);
            if (this.equals(structureCopy, this) == false)
                nextStates.Add(structureCopy);

            //Left
            structureCopy = this.DeepCopy();
            structureCopy.moveLeft(moves);
            if (this.equals(structureCopy, this) == false)
                nextStates.Add(structureCopy);

            return nextStates;
        }
        public Structure DeepCopy()
        {
            Structure deepCopy = new Structure();
            for (int i = 0; i < this.width; i++)
            {
                for (int j = 0; j < this.hight; j++)
                {
                    deepCopy.Array[i, j] = new Block();
                    deepCopy.Array[i, j].Name = this.Array[i, j].Name;
                    deepCopy.Array[i, j].Number = this.Array[i, j].Number;
                }
            }
            deepCopy.Num = new NumberBlock[this.numCount];
            deepCopy.NumGoal = new NumberBlock[this.numCount];
            for (int i = 0; i < this.numCount; i++)
            {
                deepCopy.Num[i] = new NumberBlock();
                deepCopy.Num[i].x = this.Num[i].x;
                deepCopy.Num[i].y = this.Num[i].y;

                deepCopy.NumGoal[i] = new NumberBlock();
                deepCopy.NumGoal[i].x = this.NumGoal[i].x;
                deepCopy.NumGoal[i].y = this.NumGoal[i].y;
            }
            deepCopy.numCount = this.numCount;

            //set father node
            deepCopy.father = new Structure();
            deepCopy.father = this;

            //set Node Level
            deepCopy.Cost = deepCopy.father.Cost + 1;

            return deepCopy;
        }

        public int getHeuristic()
        {
            int heu = 0;
            for (int i = 0; i < this.numCount; i++)
            {
                heu += Math.Abs(this.Num[i].x - this.NumGoal[i].x) + Math.Abs(this.Num[i].y - this.NumGoal[i].y);
            }
            return heu;
        }

        public string getHashString()
        {
            string hash = "";
            for (int i = 0; i < this.width; i++)
            {
                for (int j = 0; j < this.hight; j++)
                {
                    switch (this.Array[i, j].Name)
                    {
                        case blockName.Wall:
                            hash += "W";
                            break;
                        case blockName.Empty:
                            hash += "E";
                            break;
                        case blockName.Num:
                            hash += "N";
                            hash += this.Array[i, j].Number.ToString();
                            break;
                        case blockName.NumGoal:
                            hash += "G";
                            hash += this.Array[i, j].Number.ToString();
                            break;
                    }
                }
            }
            return hash;
        }

    }



}
