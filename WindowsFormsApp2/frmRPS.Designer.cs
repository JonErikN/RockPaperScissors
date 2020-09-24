namespace WindowsFormsApp2
{
    partial class frmRockPaperScissors
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
            this.components = new System.ComponentModel.Container();
            this.lblChooseWeapon = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.picHuman = new System.Windows.Forms.PictureBox();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCountDown = new System.Windows.Forms.Button();
            this.picHumanChoice = new System.Windows.Forms.PictureBox();
            this.lblHumanChoice = new System.Windows.Forms.Label();
            this.tmrStartCount = new System.Windows.Forms.Timer(this.components);
            this.btnResult = new System.Windows.Forms.Button();
            this.btnHumanScore = new System.Windows.Forms.Button();
            this.lblComuterScore = new System.Windows.Forms.Label();
            this.lblHumanScore = new System.Windows.Forms.Label();
            this.btnComputerScore = new System.Windows.Forms.Button();
            this.btnDrawScore = new System.Windows.Forms.Button();
            this.lblDrawNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHumanChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChooseWeapon
            // 
            this.lblChooseWeapon.AutoSize = true;
            this.lblChooseWeapon.Location = new System.Drawing.Point(18, 9);
            this.lblChooseWeapon.Name = "lblChooseWeapon";
            this.lblChooseWeapon.Size = new System.Drawing.Size(215, 20);
            this.lblChooseWeapon.TabIndex = 0;
            this.lblChooseWeapon.Text = "Human, choose your weapon";
            this.lblChooseWeapon.Click += new System.EventHandler(this.lblChooseWeapon_Click);
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(22, 52);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(121, 48);
            this.btnRock.TabIndex = 1;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(22, 160);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(121, 48);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(22, 106);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(121, 48);
            this.btnPaper.TabIndex = 3;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // picHuman
            // 
            this.picHuman.Location = new System.Drawing.Point(22, 225);
            this.picHuman.Name = "picHuman";
            this.picHuman.Size = new System.Drawing.Size(307, 110);
            this.picHuman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHuman.TabIndex = 4;
            this.picHuman.TabStop = false;
            // 
            // picComputer
            // 
            this.picComputer.Location = new System.Drawing.Point(353, 225);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(307, 110);
            this.picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picComputer.TabIndex = 5;
            this.picComputer.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(199, 52);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(287, 48);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Computer, choose your weapon";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "Paper";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(539, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 48);
            this.button3.TabIndex = 9;
            this.button3.Text = "Scissors";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(539, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 48);
            this.button4.TabIndex = 8;
            this.button4.Text = "Rock";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnCountDown
            // 
            this.btnCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountDown.Location = new System.Drawing.Point(268, 106);
            this.btnCountDown.Name = "btnCountDown";
            this.btnCountDown.Size = new System.Drawing.Size(159, 102);
            this.btnCountDown.TabIndex = 11;
            this.btnCountDown.UseVisualStyleBackColor = true;
            this.btnCountDown.Click += new System.EventHandler(this.button5_Click);
            // 
            // picHumanChoice
            // 
            this.picHumanChoice.Location = new System.Drawing.Point(162, 160);
            this.picHumanChoice.Name = "picHumanChoice";
            this.picHumanChoice.Size = new System.Drawing.Size(100, 45);
            this.picHumanChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHumanChoice.TabIndex = 12;
            this.picHumanChoice.TabStop = false;
            // 
            // lblHumanChoice
            // 
            this.lblHumanChoice.AutoSize = true;
            this.lblHumanChoice.Location = new System.Drawing.Point(162, 133);
            this.lblHumanChoice.Name = "lblHumanChoice";
            this.lblHumanChoice.Size = new System.Drawing.Size(97, 20);
            this.lblHumanChoice.TabIndex = 13;
            this.lblHumanChoice.Text = "Your choice:";
            // 
            // tmrStartCount
            // 
            this.tmrStartCount.Interval = 600;
            this.tmrStartCount.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnResult.Location = new System.Drawing.Point(22, 341);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(638, 103);
            this.btnResult.TabIndex = 14;
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // btnHumanScore
            // 
            this.btnHumanScore.Location = new System.Drawing.Point(22, 479);
            this.btnHumanScore.Name = "btnHumanScore";
            this.btnHumanScore.Size = new System.Drawing.Size(75, 64);
            this.btnHumanScore.TabIndex = 15;
            this.btnHumanScore.Text = "0";
            this.btnHumanScore.UseVisualStyleBackColor = true;
            // 
            // lblComuterScore
            // 
            this.lblComuterScore.AutoSize = true;
            this.lblComuterScore.Location = new System.Drawing.Point(534, 451);
            this.lblComuterScore.Name = "lblComuterScore";
            this.lblComuterScore.Size = new System.Drawing.Size(126, 20);
            this.lblComuterScore.TabIndex = 17;
            this.lblComuterScore.Text = "Computer score:";
            // 
            // lblHumanScore
            // 
            this.lblHumanScore.AutoSize = true;
            this.lblHumanScore.Location = new System.Drawing.Point(18, 451);
            this.lblHumanScore.Name = "lblHumanScore";
            this.lblHumanScore.Size = new System.Drawing.Size(108, 20);
            this.lblHumanScore.TabIndex = 18;
            this.lblHumanScore.Text = "Human score:";
            // 
            // btnComputerScore
            // 
            this.btnComputerScore.Location = new System.Drawing.Point(585, 479);
            this.btnComputerScore.Name = "btnComputerScore";
            this.btnComputerScore.Size = new System.Drawing.Size(75, 64);
            this.btnComputerScore.TabIndex = 19;
            this.btnComputerScore.Text = "0";
            this.btnComputerScore.UseVisualStyleBackColor = true;
            // 
            // btnDrawScore
            // 
            this.btnDrawScore.Location = new System.Drawing.Point(310, 479);
            this.btnDrawScore.Name = "btnDrawScore";
            this.btnDrawScore.Size = new System.Drawing.Size(75, 64);
            this.btnDrawScore.TabIndex = 20;
            this.btnDrawScore.Text = "0";
            this.btnDrawScore.UseVisualStyleBackColor = true;
            // 
            // lblDrawNumber
            // 
            this.lblDrawNumber.AutoSize = true;
            this.lblDrawNumber.Location = new System.Drawing.Point(280, 451);
            this.lblDrawNumber.Name = "lblDrawNumber";
            this.lblDrawNumber.Size = new System.Drawing.Size(133, 20);
            this.lblDrawNumber.TabIndex = 21;
            this.lblDrawNumber.Text = "Number of draws:";
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 673);
            this.Controls.Add(this.lblDrawNumber);
            this.Controls.Add(this.btnDrawScore);
            this.Controls.Add(this.btnComputerScore);
            this.Controls.Add(this.lblHumanScore);
            this.Controls.Add(this.lblComuterScore);
            this.Controls.Add(this.btnHumanScore);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblHumanChoice);
            this.Controls.Add(this.picHumanChoice);
            this.Controls.Add(this.btnCountDown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picComputer);
            this.Controls.Add(this.picHuman);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.lblChooseWeapon);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.frmRockPaperScissors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHumanChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseWeapon;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.PictureBox picHuman;
        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCountDown;
        private System.Windows.Forms.PictureBox picHumanChoice;
        private System.Windows.Forms.Label lblHumanChoice;
        private System.Windows.Forms.Timer tmrStartCount;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnHumanScore;
        private System.Windows.Forms.Label lblComuterScore;
        private System.Windows.Forms.Label lblHumanScore;
        private System.Windows.Forms.Button btnComputerScore;
        private System.Windows.Forms.Button btnDrawScore;
        private System.Windows.Forms.Label lblDrawNumber;
    }
}