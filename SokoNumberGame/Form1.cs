using System;
using System.Drawing;
using System.Windows.Forms;

namespace SokoNumberGame
{
    public partial class Form1 : Form
    {
        private Structure s;
        private Logic l;

        //this objects just for drawing
        private Graphics drawObject;
        private Font drawFont;
        private StringFormat drawFormat;

        //Enable KeyBoard
        private bool KeyBoard;

        //counter for every move
        public int movesCount;
        public TimeSpan time;
        public int visitedCount;
        
        //constructor
        public Form1()
        {
            //initialization
            this.movesCount = 0;
            this.l = new Logic();
            this.KeyPreview = false;
            this.s = new Structure();
            this.KeyBoard = false;
            drawObject = this.CreateGraphics();
            drawFormat = new StringFormat();
            InitializeComponent();
        }

        //this functions just for drawing
        public void drawShadow(int x, int y, int width, int higth)
        {
            drawObject.FillRectangle(new SolidBrush(Color.Black), x + 1, y + 1, width + 2, higth + 2);
        }
        public void drawEmpty(int x = 10, int y = 10)
        {
            this.drawShadow(x, y, this.s.blockLength, this.s.blockLength);
            drawObject.FillRectangle(new SolidBrush(Color.LightGray), x, y, this.s.blockLength, this.s.blockLength);
        }
        public void drawWall(int x = 10, int y = 10)
        {
            this.drawShadow(x, y, this.s.blockLength, this.s.blockLength);
            drawObject.FillRectangle(new SolidBrush(Color.HotPink), x, y, this.s.blockLength, this.s.blockLength);
        }
        public void drawNumber(string text = "1", int x = 10, int y = 10)
        {
            this.drawFont = new Font("Arial", this.s.blockLength * 24 / 50);
            this.drawShadow(x, y, this.s.blockLength, this.s.blockLength);
            drawObject.FillRectangle(new SolidBrush(Color.DarkSlateGray), x, y, this.s.blockLength, this.s.blockLength);
            drawObject.DrawString(text, this.drawFont, new SolidBrush(Color.White), x + this.s.blockLength / 2 - this.s.spaceBetweenBlocks, y + this.s.blockLength / 2 - this.s.spaceBetweenBlocks, this.drawFormat);
        }
        public void drawNumberGoal(string text = "1", int x = 10, int y = 10)
        {
            this.drawFont = new Font("Arial", this.s.blockLength * 24 / 50);
            this.drawShadow(x, y, this.s.blockLength, this.s.blockLength);
            drawObject.FillRectangle(new SolidBrush(Color.White), x, y, this.s.blockLength, this.s.blockLength);
            drawObject.DrawString(text, this.drawFont, new SolidBrush(Color.LightGray), x + this.s.blockLength / 2 - this.s.spaceBetweenBlocks, y + this.s.blockLength / 2 - this.s.spaceBetweenBlocks, this.drawFormat);
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            this.stage_number.Text = this.getStage().ToString();
            this.NextStage.BackColor = System.Drawing.Color.Thistle;
            this.NextStage.Enabled = false;
            this.movesCount = 0;
            this.moves_count.Text = movesCount.ToString();
            s.declareStage();
            s.print(this);
            this.playMode();
        }
        private void playMode()
        {
            this.lblPlayMode.Text = s.algorithm.ToString();
            switch (s.algorithm)
            {
                case Algorithm.UserPlay:
                    KeyBoard = true;
                    s.print(this);
                    break;
                case Algorithm.DFS:
                    this.l.DFS(s, this);
                    this.moves_count.Text = movesCount.ToString();
                    KeyBoard = false;
                    this.l.printSolution(this, s.speed);
                    showTimeAndVisited();
                    break;
                case Algorithm.BFS:
                    this.l.BFS(s, this);
                    this.moves_count.Text = movesCount.ToString();
                    KeyBoard = false;
                    this.l.printSolution(this, s.speed);
                    showTimeAndVisited();
                    break;
                case Algorithm.UCS:
                    this.l.UCS(s, this);
                    this.moves_count.Text = movesCount.ToString();
                    KeyBoard = false;
                    this.l.printSolution(this, s.speed);
                    showTimeAndVisited();
                    break;
                case Algorithm.A_STAR:
                    this.l.A_Star(s, this);
                    this.moves_count.Text = movesCount.ToString();
                    KeyBoard = false;
                    this.l.printSolution(this, s.speed);
                    showTimeAndVisited();
                    break;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void showTimeAndVisited()
        {
            this.LabelTime.Visible = true;
            this.LabelVisitedCount.Visible = true;
            this.lblTime.Visible = true;
            this.lblVisitedCount.Visible = true;
            this.lblTime.Text = this.time.ToString();
            this.lblVisitedCount.Text = this.visitedCount.ToString();
        }
        //set and get stage
        public void setStage(int stage)
        {
            s.stage = stage;
        }
        public int getStage()
        {
            return s.stage;
        }
        //set and get speed
        public void setSpeed(decimal speed)
        {
            s.speed = speed;
        }
        public decimal getSpeed()
        {
            return s.speed;
        }
        //set and get algorithm
        public void setAlgorithm(Algorithm algorithm)
        {
            s.algorithm = algorithm;
        }
        public Algorithm getAlgorithm()
        {
            return s.algorithm;
        }
        //Next Stage Button
        private void NextStage_Click(object sender, EventArgs e)
        {
            s.stage++;
            if (s.stage > 6)
            {
                this.Hide();
                Application.Restart();
            }
            this.Form1_Shown(sender, e);
        }
        //Try Agin Button
        private void TryAgain_Click(object sender, EventArgs e)
        {
            this.movesCount = 0;
            this.moves_count.Text = movesCount.ToString();
            s.declareStage();
            s.print(this);
            this.playMode();
        }
        //Main Menu Button
        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Restart();
        }



        //User Play Method
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.KeyBoard)
            {
                switch (keyData)
                {
                    case Keys.W:
                    case Keys.Up:
                        this.movesCount++;
                        this.moves_count.Text = movesCount.ToString();
                        this.s.moveUp(s.checkMoves());
                        s.print(this);
                        break;
                    case Keys.S:
                    case Keys.Down:
                        this.movesCount++;
                        this.moves_count.Text = movesCount.ToString();
                        this.s.moveDown(s.checkMoves());
                        s.print(this);
                        break;
                    case Keys.D:
                    case Keys.Right:
                        this.movesCount++;
                        this.moves_count.Text = movesCount.ToString();
                        this.s.moveRight(s.checkMoves());
                        s.print(this);
                        break;
                    case Keys.A:
                    case Keys.Left:
                        this.movesCount++;
                        this.moves_count.Text = movesCount.ToString();
                        this.s.moveLeft(s.checkMoves());
                        s.print(this);
                        break;
                    case Keys.Escape:
                        this.Close();
                        break;
                }
            }
            if (this.s.isFinal() == true)
            {
                MessageBox.Show("You Are Winner");
                this.NextStage.Enabled = true;
                this.NextStage.BackColor = System.Drawing.Color.Purple;

            }
            return true;
        }


    }
}
