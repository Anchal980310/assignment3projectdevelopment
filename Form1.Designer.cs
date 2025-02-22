namespace tictactoe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblGridSize = new Label();
            cmbBoxGridSize = new ComboBox();
            lblRound = new Label();
            labelScoreBoard = new Label();
            lblPlayer2 = new Label();
            btnStartNewGame = new Button();
            btnExit = new Button();
            lblPlayer1 = new Label();
            pnlPlayer1 = new Panel();
            txtBoxPlayer1Wins = new TextBox();
            pnlPlayer2 = new Panel();
            txtBoxPlayer2Wins = new TextBox();
            textBoxDisplayRounds = new TextBox();
            pnlPlayer1.SuspendLayout();
            pnlPlayer2.SuspendLayout();
            SuspendLayout();
            // 
            // lblGridSize
            // 
            lblGridSize.AutoSize = true;
            lblGridSize.BackColor = Color.MidnightBlue;
            lblGridSize.ForeColor = Color.LightPink;
            lblGridSize.Location = new Point(694, 73);
            lblGridSize.Margin = new Padding(4, 0, 4, 0);
            lblGridSize.Name = "lblGridSize";
            lblGridSize.Size = new Size(81, 25);
            lblGridSize.TabIndex = 0;
            lblGridSize.Text = "Grid Size";
            // 
            // cmbBoxGridSize
            // 
            cmbBoxGridSize.BackColor = Color.GhostWhite;
            cmbBoxGridSize.ForeColor = Color.DarkGreen;
            cmbBoxGridSize.FormattingEnabled = true;
            cmbBoxGridSize.Items.AddRange(new object[] { "3x3", "5x5" });
            cmbBoxGridSize.Location = new Point(868, 65);
            cmbBoxGridSize.Margin = new Padding(4);
            cmbBoxGridSize.Name = "cmbBoxGridSize";
            cmbBoxGridSize.Size = new Size(215, 33);
            cmbBoxGridSize.TabIndex = 1;
            cmbBoxGridSize.Text = "3x3";
            cmbBoxGridSize.SelectedIndexChanged += comboBoxGridSize_SelectedIndexChanged;
            // 
            // lblRound
            // 
            lblRound.AutoSize = true;
            lblRound.BackColor = Color.MidnightBlue;
            lblRound.ForeColor = Color.LightPink;
            lblRound.Location = new Point(694, 136);
            lblRound.Margin = new Padding(4, 0, 4, 0);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(64, 25);
            lblRound.TabIndex = 2;
            lblRound.Text = "Round";
            // 
            // labelScoreBoard
            // 
            labelScoreBoard.AutoSize = true;
            labelScoreBoard.BackColor = Color.MidnightBlue;
            labelScoreBoard.ForeColor = Color.LightPink;
            labelScoreBoard.Location = new Point(824, 196);
            labelScoreBoard.Margin = new Padding(4, 0, 4, 0);
            labelScoreBoard.Name = "labelScoreBoard";
            labelScoreBoard.Size = new Size(98, 25);
            labelScoreBoard.TabIndex = 4;
            labelScoreBoard.Text = "Score Card";
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.BackColor = Color.MidnightBlue;
            lblPlayer2.ForeColor = Color.LightPink;
            lblPlayer2.Location = new Point(20, 26);
            lblPlayer2.Margin = new Padding(4, 0, 4, 0);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(74, 25);
            lblPlayer2.TabIndex = 0;
            lblPlayer2.Text = "Player 2";
            // 
            // btnStartNewGame
            // 
            btnStartNewGame.BackColor = Color.GhostWhite;
            btnStartNewGame.ForeColor = Color.DarkGreen;
            btnStartNewGame.Location = new Point(670, 631);
            btnStartNewGame.Margin = new Padding(4);
            btnStartNewGame.Name = "btnStartNewGame";
            btnStartNewGame.Size = new Size(176, 72);
            btnStartNewGame.TabIndex = 7;
            btnStartNewGame.Text = "New Game";
            btnStartNewGame.UseVisualStyleBackColor = false;
            btnStartNewGame.Click += buttonStartNewGame_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.GhostWhite;
            btnExit.ForeColor = Color.DarkGreen;
            btnExit.Location = new Point(940, 631);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(182, 72);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += buttonExit_Click;
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.BackColor = Color.MidnightBlue;
            lblPlayer1.ForeColor = Color.LightPink;
            lblPlayer1.Location = new Point(24, 26);
            lblPlayer1.Margin = new Padding(4, 0, 4, 0);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(74, 25);
            lblPlayer1.TabIndex = 0;
            lblPlayer1.Text = "Player 1";
            // 
            // pnlPlayer1
            // 
            pnlPlayer1.BackColor = Color.GhostWhite;
            pnlPlayer1.Controls.Add(txtBoxPlayer1Wins);
            pnlPlayer1.Controls.Add(lblPlayer1);
            pnlPlayer1.Location = new Point(670, 260);
            pnlPlayer1.Margin = new Padding(4);
            pnlPlayer1.Name = "pnlPlayer1";
            pnlPlayer1.Size = new Size(176, 325);
            pnlPlayer1.TabIndex = 9;
            pnlPlayer1.Paint += panelPlayer1_Paint;
            // 
            // txtBoxPlayer1Wins
            // 
            txtBoxPlayer1Wins.Location = new Point(24, 181);
            txtBoxPlayer1Wins.Margin = new Padding(4);
            txtBoxPlayer1Wins.Name = "txtBoxPlayer1Wins";
            txtBoxPlayer1Wins.ReadOnly = true;
            txtBoxPlayer1Wins.Size = new Size(75, 31);
            txtBoxPlayer1Wins.TabIndex = 2;
            txtBoxPlayer1Wins.TextAlign = HorizontalAlignment.Center;
            // 
            // pnlPlayer2
            // 
            pnlPlayer2.BackColor = Color.GhostWhite;
            pnlPlayer2.Controls.Add(txtBoxPlayer2Wins);
            pnlPlayer2.Controls.Add(lblPlayer2);
            pnlPlayer2.Location = new Point(940, 265);
            pnlPlayer2.Margin = new Padding(4);
            pnlPlayer2.Name = "pnlPlayer2";
            pnlPlayer2.Size = new Size(182, 325);
            pnlPlayer2.TabIndex = 10;
            // 
            // txtBoxPlayer2Wins
            // 
            txtBoxPlayer2Wins.Location = new Point(20, 181);
            txtBoxPlayer2Wins.Margin = new Padding(4);
            txtBoxPlayer2Wins.Name = "txtBoxPlayer2Wins";
            txtBoxPlayer2Wins.ReadOnly = true;
            txtBoxPlayer2Wins.Size = new Size(75, 31);
            txtBoxPlayer2Wins.TabIndex = 3;
            txtBoxPlayer2Wins.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDisplayRounds
            // 
            textBoxDisplayRounds.BackColor = Color.GhostWhite;
            textBoxDisplayRounds.ForeColor = Color.DarkGreen;
            textBoxDisplayRounds.Location = new Point(868, 130);
            textBoxDisplayRounds.Margin = new Padding(4);
            textBoxDisplayRounds.Name = "textBoxDisplayRounds";
            textBoxDisplayRounds.ReadOnly = true;
            textBoxDisplayRounds.Size = new Size(215, 31);
            textBoxDisplayRounds.TabIndex = 11;
            textBoxDisplayRounds.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1311, 908);
            Controls.Add(textBoxDisplayRounds);
            Controls.Add(pnlPlayer2);
            Controls.Add(pnlPlayer1);
            Controls.Add(btnExit);
            Controls.Add(btnStartNewGame);
            Controls.Add(labelScoreBoard);
            Controls.Add(lblRound);
            Controls.Add(cmbBoxGridSize);
            Controls.Add(lblGridSize);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "tictactoe";
            Load += Form1_Load;
            pnlPlayer1.ResumeLayout(false);
            pnlPlayer1.PerformLayout();
            pnlPlayer2.ResumeLayout(false);
            pnlPlayer2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblGridSize;
        private System.Windows.Forms.ComboBox cmbBoxGridSize;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label labelScoreBoard;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Button btnStartNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.TextBox textBoxDisplayRounds;
        private System.Windows.Forms.TextBox txtBoxPlayer1Wins;
        private System.Windows.Forms.TextBox txtBoxPlayer2Wins;
    }
}
