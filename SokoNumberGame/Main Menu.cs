using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SokoNumberGame
{
    public enum Algorithm
    {
        UserPlay,
        DFS,
        BFS,
        UCS,
        A_STAR
    };
    public partial class Main_Menu : Form
    {
        private int stage;
        private Algorithm algorithm;
        private decimal speed;
        
        public Main_Menu()
        {
            stage = 1;
            algorithm = Algorithm.UserPlay;
            speed = 10;
            InitializeComponent();
        }
        //clear stage buttons
        private void clearStageBtns()
        {
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button3.BackColor = System.Drawing.Color.Thistle;
            this.button4.BackColor = System.Drawing.Color.Thistle;
            this.button5.BackColor = System.Drawing.Color.Thistle;
            this.button6.BackColor = System.Drawing.Color.Thistle;
        }//clear play mode
        private void clearPlayMode()
        {
            this.btnUserPlay.BackColor = System.Drawing.Color.Thistle;
            this.btnDFS.BackColor = System.Drawing.Color.Thistle;
            this.btnBFS.BackColor = System.Drawing.Color.Thistle;
            this.btnUCS.BackColor = System.Drawing.Color.Thistle;
            this.btnAStar.BackColor = System.Drawing.Color.Thistle;
        }
        //stage1
        private void Button1_Click(object sender, EventArgs e)
        {
            clearStageBtns();
            this.button1.BackColor = System.Drawing.Color.Magenta;
            stage = 1;
        }
        //stage2
        private void Button2_Click(object sender, EventArgs e)
        {
            clearStageBtns();
            this.button2.BackColor = System.Drawing.Color.Magenta;
            stage = 2;
        }
        //stage3
        private void Button3_Click(object sender, EventArgs e)
        {
            clearStageBtns();
            this.button3.BackColor = System.Drawing.Color.Magenta;
            stage = 3;
        }
        //stage4
        private void Button4_Click(object sender, EventArgs e)
        {
            clearStageBtns();
            this.button4.BackColor = System.Drawing.Color.Magenta;
            stage = 4;
        }
        //stage5
        private void Button5_Click(object sender, EventArgs e)
        {
            clearStageBtns();
            this.button5.BackColor = System.Drawing.Color.Magenta;
            stage = 5;
        }
        //stage6
        private void Button6_Click(object sender, EventArgs e)
        {
            clearStageBtns();
            this.button6.BackColor = System.Drawing.Color.Magenta;
            stage = 6;
        }
        //UserPlay
        private void btnUserPlay_Click(object sender, EventArgs e)
        {
            clearPlayMode();
            this.btnUserPlay.BackColor = System.Drawing.Color.Magenta;
            algorithm = Algorithm.UserPlay;
            this.nudSpeed.Enabled = false;
        }
        //DFS
        private void btnDFS_Click(object sender, EventArgs e)
        {
            clearPlayMode();
            this.btnDFS.BackColor = System.Drawing.Color.Magenta;
            algorithm = Algorithm.DFS;
            this.nudSpeed.Enabled = true;
        }
        //BFS
        private void btnBFS_Click(object sender, EventArgs e)
        {
            clearPlayMode();
            this.btnBFS.BackColor = System.Drawing.Color.Magenta;
            algorithm = Algorithm.BFS;
            this.nudSpeed.Enabled = true;
        }
        //UCS
        private void btnUCS_Click(object sender, EventArgs e)
        {
            clearPlayMode();
            this.btnUCS.BackColor = System.Drawing.Color.Magenta;
            algorithm = Algorithm.UCS;
            this.nudSpeed.Enabled = true;
        }
        //A*
        private void btnAStar_Click(object sender, EventArgs e)
        {
            clearPlayMode();
            this.btnAStar.BackColor = System.Drawing.Color.Magenta;
            algorithm = Algorithm.A_STAR;
            this.nudSpeed.Enabled = true;
        }
        //speed
        private void NudSpeed_ValueChanged(object sender, EventArgs e)
        {
            speed = nudSpeed.Value;

        }
        //start_game
        private void StartGame_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.setStage(this.stage);
            form.setSpeed(this.speed);
            form.setAlgorithm(this.algorithm);
            form.Show();
            this.Hide();
        }

    }
}
