using System;
using System.Linq;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            RadioButton checkedButton = pnlDifficulty.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {
                string difficulty = checkedButton.Name;
                PlayForm play = new PlayForm();
                play.Difficulty = difficulty;
                play.Show();
            }
            else
            { 
                lblError.Show();
            }
        }
    }
}
