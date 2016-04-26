namespace Sudoku
{
    partial class PlayForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.GameBoard = new Sudoku.Board();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(161, -11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(342, 90);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Sudoku";
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.Green;
            this.PlayBtn.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.ForeColor = System.Drawing.Color.White;
            this.PlayBtn.Location = new System.Drawing.Point(179, 325);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(234, 105);
            this.PlayBtn.TabIndex = 2;
            this.PlayBtn.Text = "Play!";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtnClick);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(142, 655);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(416, 111);
            this.lblTime.TabIndex = 3;
            this.lblTime.Visible = false;
            // 
            // GameBoard
            // 
            this.GameBoard.Location = new System.Drawing.Point(18, 102);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(550, 550);
            this.GameBoard.TabIndex = 0;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 775);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.GameBoard);
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayForm";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Board GameBoard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lblTime;
    }
}