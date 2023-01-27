namespace SokoNumberGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NextStage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TryAgain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.moves_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stage_number = new System.Windows.Forms.Label();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.LabelTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.LabelVisitedCount = new System.Windows.Forms.Label();
            this.lblVisitedCount = new System.Windows.Forms.Label();
            this.LablePlayMode = new System.Windows.Forms.Label();
            this.lblPlayMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NextStage
            // 
            this.NextStage.BackColor = System.Drawing.Color.Thistle;
            this.NextStage.Font = new System.Drawing.Font("Baloo 2", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextStage.ForeColor = System.Drawing.Color.White;
            this.NextStage.Location = new System.Drawing.Point(18, 353);
            this.NextStage.Name = "NextStage";
            this.NextStage.Size = new System.Drawing.Size(312, 76);
            this.NextStage.TabIndex = 2;
            this.NextStage.Text = "Next Stage";
            this.NextStage.UseVisualStyleBackColor = false;
            this.NextStage.Click += new System.EventHandler(this.NextStage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baloo 2", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(412, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soko Number ";
            // 
            // TryAgain
            // 
            this.TryAgain.BackColor = System.Drawing.Color.MediumVioletRed;
            this.TryAgain.Font = new System.Drawing.Font("Baloo 2", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TryAgain.ForeColor = System.Drawing.Color.White;
            this.TryAgain.Location = new System.Drawing.Point(353, 353);
            this.TryAgain.Name = "TryAgain";
            this.TryAgain.Size = new System.Drawing.Size(312, 76);
            this.TryAgain.TabIndex = 2;
            this.TryAgain.Text = "Try Again";
            this.TryAgain.UseVisualStyleBackColor = false;
            this.TryAgain.Click += new System.EventHandler(this.TryAgain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(416, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Moves Count:";
            // 
            // moves_count
            // 
            this.moves_count.AutoSize = true;
            this.moves_count.BackColor = System.Drawing.Color.Transparent;
            this.moves_count.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moves_count.ForeColor = System.Drawing.Color.Purple;
            this.moves_count.Location = new System.Drawing.Point(548, 134);
            this.moves_count.Name = "moves_count";
            this.moves_count.Size = new System.Drawing.Size(26, 31);
            this.moves_count.TabIndex = 3;
            this.moves_count.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(416, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stage:";
            // 
            // stage_number
            // 
            this.stage_number.AutoSize = true;
            this.stage_number.BackColor = System.Drawing.Color.Transparent;
            this.stage_number.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stage_number.ForeColor = System.Drawing.Color.Purple;
            this.stage_number.Location = new System.Drawing.Point(481, 176);
            this.stage_number.Name = "stage_number";
            this.stage_number.Size = new System.Drawing.Size(21, 31);
            this.stage_number.TabIndex = 3;
            this.stage_number.Text = "1";
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.MainMenuButton.Font = new System.Drawing.Font("Baloo 2", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuButton.ForeColor = System.Drawing.Color.White;
            this.MainMenuButton.Location = new System.Drawing.Point(353, 271);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(312, 76);
            this.MainMenuButton.TabIndex = 2;
            this.MainMenuButton.Text = "MainMenu";
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelTime.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.ForeColor = System.Drawing.Color.Purple;
            this.LabelTime.Location = new System.Drawing.Point(29, 288);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(62, 31);
            this.LabelTime.TabIndex = 3;
            this.LabelTime.Text = "Time:";
            this.LabelTime.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Purple;
            this.lblTime.Location = new System.Drawing.Point(97, 288);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(21, 31);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "1";
            this.lblTime.Visible = false;
            // 
            // LabelVisitedCount
            // 
            this.LabelVisitedCount.AutoSize = true;
            this.LabelVisitedCount.BackColor = System.Drawing.Color.Transparent;
            this.LabelVisitedCount.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVisitedCount.ForeColor = System.Drawing.Color.Purple;
            this.LabelVisitedCount.Location = new System.Drawing.Point(416, 91);
            this.LabelVisitedCount.Name = "LabelVisitedCount";
            this.LabelVisitedCount.Size = new System.Drawing.Size(188, 31);
            this.LabelVisitedCount.TabIndex = 3;
            this.LabelVisitedCount.Text = "Visited State Count:";
            this.LabelVisitedCount.Visible = false;
            // 
            // lblVisitedCount
            // 
            this.lblVisitedCount.AutoSize = true;
            this.lblVisitedCount.BackColor = System.Drawing.Color.Transparent;
            this.lblVisitedCount.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitedCount.ForeColor = System.Drawing.Color.Purple;
            this.lblVisitedCount.Location = new System.Drawing.Point(600, 91);
            this.lblVisitedCount.Name = "lblVisitedCount";
            this.lblVisitedCount.Size = new System.Drawing.Size(21, 31);
            this.lblVisitedCount.TabIndex = 3;
            this.lblVisitedCount.Text = "1";
            this.lblVisitedCount.Visible = false;
            // 
            // LablePlayMode
            // 
            this.LablePlayMode.AutoSize = true;
            this.LablePlayMode.BackColor = System.Drawing.Color.Transparent;
            this.LablePlayMode.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LablePlayMode.ForeColor = System.Drawing.Color.Purple;
            this.LablePlayMode.Location = new System.Drawing.Point(416, 220);
            this.LablePlayMode.Name = "LablePlayMode";
            this.LablePlayMode.Size = new System.Drawing.Size(107, 31);
            this.LablePlayMode.TabIndex = 3;
            this.LablePlayMode.Text = "Play Mode:";
            // 
            // lblPlayMode
            // 
            this.lblPlayMode.AutoSize = true;
            this.lblPlayMode.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayMode.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayMode.ForeColor = System.Drawing.Color.Purple;
            this.lblPlayMode.Location = new System.Drawing.Point(519, 220);
            this.lblPlayMode.Name = "lblPlayMode";
            this.lblPlayMode.Size = new System.Drawing.Size(95, 31);
            this.lblPlayMode.TabIndex = 3;
            this.lblPlayMode.Text = "User Play";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.moves_count);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblVisitedCount);
            this.Controls.Add(this.lblPlayMode);
            this.Controls.Add(this.stage_number);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelVisitedCount);
            this.Controls.Add(this.LablePlayMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.TryAgain);
            this.Controls.Add(this.NextStage);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextStage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TryAgain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label moves_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label stage_number;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label LabelVisitedCount;
        private System.Windows.Forms.Label lblVisitedCount;
        private System.Windows.Forms.Label LablePlayMode;
        private System.Windows.Forms.Label lblPlayMode;
    }
}

