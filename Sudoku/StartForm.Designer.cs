namespace Sudoku
{
    partial class StartForm
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlDifficulty = new System.Windows.Forms.Panel();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(42, 102);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(55, 32);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "View High Scrores";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pnlDifficulty
            // 
            this.pnlDifficulty.Controls.Add(this.lblDifficulty);
            this.pnlDifficulty.Controls.Add(this.rbHard);
            this.pnlDifficulty.Controls.Add(this.rbMedium);
            this.pnlDifficulty.Controls.Add(this.rbEasy);
            this.pnlDifficulty.Location = new System.Drawing.Point(307, 80);
            this.pnlDifficulty.Name = "pnlDifficulty";
            this.pnlDifficulty.Size = new System.Drawing.Size(124, 115);
            this.pnlDifficulty.TabIndex = 2;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(19, 7);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(85, 17);
            this.lblDifficulty.TabIndex = 3;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHard.Location = new System.Drawing.Point(19, 84);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(50, 16);
            this.rbHard.TabIndex = 2;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(19, 61);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(66, 16);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEasy.Location = new System.Drawing.Point(19, 38);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(49, 16);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(259, 198);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(205, 24);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "Choose a difficulty.";
            this.lblError.Visible = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 346);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.pnlDifficulty);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPlay);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.pnlDifficulty.ResumeLayout(false);
            this.pnlDifficulty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlDifficulty;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.Label lblError;
    }
}

