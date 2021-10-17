namespace PaddleWar
{
    partial class frmMain
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.picGameOver = new System.Windows.Forms.PictureBox();
            this.picPaddle = new System.Windows.Forms.PictureBox();
            this.lblBall = new System.Windows.Forms.Label();
            this.lblBounce = new System.Windows.Forms.Label();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblScore);
            this.pnlMain.Controls.Add(this.lblStart);
            this.pnlMain.Controls.Add(this.lblGameOver);
            this.pnlMain.Controls.Add(this.picGameOver);
            this.pnlMain.Controls.Add(this.picPaddle);
            this.pnlMain.Controls.Add(this.lblBall);
            this.pnlMain.Controls.Add(this.lblBounce);
            this.pnlMain.Controls.Add(this.picBall);
            this.pnlMain.Controls.Add(this.btnStart);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1144, 564);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Click += new System.EventHandler(this.pnlMain_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Black;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblScore.Location = new System.Drawing.Point(1063, 34);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(47, 13);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score: 0";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStart.Location = new System.Drawing.Point(449, 296);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(274, 30);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Press SPACE button to start!";
            this.lblStart.Visible = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGameOver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGameOver.Location = new System.Drawing.Point(479, 246);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(216, 50);
            this.lblGameOver.TabIndex = 2;
            this.lblGameOver.Text = "Game Over!";
            this.lblGameOver.Visible = false;
            // 
            // picGameOver
            // 
            this.picGameOver.Image = ((System.Drawing.Image)(resources.GetObject("picGameOver.Image")));
            this.picGameOver.Location = new System.Drawing.Point(387, 87);
            this.picGameOver.Name = "picGameOver";
            this.picGameOver.Size = new System.Drawing.Size(398, 274);
            this.picGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGameOver.TabIndex = 6;
            this.picGameOver.TabStop = false;
            this.picGameOver.Visible = false;
            // 
            // picPaddle
            // 
            this.picPaddle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picPaddle.Image = ((System.Drawing.Image)(resources.GetObject("picPaddle.Image")));
            this.picPaddle.Location = new System.Drawing.Point(488, 540);
            this.picPaddle.Name = "picPaddle";
            this.picPaddle.Size = new System.Drawing.Size(180, 14);
            this.picPaddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaddle.TabIndex = 3;
            this.picPaddle.TabStop = false;
            // 
            // lblBall
            // 
            this.lblBall.AutoSize = true;
            this.lblBall.BackColor = System.Drawing.Color.Black;
            this.lblBall.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBall.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBall.Location = new System.Drawing.Point(1063, 21);
            this.lblBall.Name = "lblBall";
            this.lblBall.Size = new System.Drawing.Size(67, 13);
            this.lblBall.TabIndex = 3;
            this.lblBall.Text = "Lost balls: 0";
            // 
            // lblBounce
            // 
            this.lblBounce.AutoSize = true;
            this.lblBounce.BackColor = System.Drawing.Color.Black;
            this.lblBounce.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBounce.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBounce.Location = new System.Drawing.Point(1063, 8);
            this.lblBounce.Name = "lblBounce";
            this.lblBounce.Size = new System.Drawing.Size(58, 13);
            this.lblBounce.TabIndex = 2;
            this.lblBounce.Text = "Bounce: 0";
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(563, 127);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(25, 25);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBall.TabIndex = 1;
            this.picBall.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1141, 51);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(652, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 564);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblBounce;
        private System.Windows.Forms.Label lblBall;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picPaddle;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.PictureBox picGameOver;
        private System.Windows.Forms.Label lblScore;
    }
}

