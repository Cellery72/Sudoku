namespace Sudoku
{
    partial class Square
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDigit = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDigit
            // 
            this.tbDigit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDigit.Location = new System.Drawing.Point(-1, 3);
            this.tbDigit.MaxLength = 1;
            this.tbDigit.Multiline = true;
            this.tbDigit.Name = "tbDigit";
            this.tbDigit.Size = new System.Drawing.Size(49, 46);
            this.tbDigit.TabIndex = 0;
            this.tbDigit.Text = "1";
            this.tbDigit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.tbDigit);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(50, 50);
            this.panel.TabIndex = 0;
            // 
            // Square
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "Square";
            this.Size = new System.Drawing.Size(50, 50);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbDigit;
        private System.Windows.Forms.Panel panel;
    }
}
