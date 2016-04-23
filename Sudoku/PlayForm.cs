using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class PlayForm : Form
    {
        private Difficulty difficulty;
        int secondsPassed;

        public PlayForm()
        {
            InitializeComponent();
        }
        private void PlayForm_Load(object sender, System.EventArgs e)
        {
            GameBoard.Enabled = false;
            secondsPassed = 0;
        }



        // ***************
        // Event Handlers
        // ***************
        private void PlayBtnClick(object sender, System.EventArgs e)
        {
            // generate FinalValues of each square 

            // start timer display in label
            GameTimer.Start();


            // hide button
            PlayBtn.Hide();
            lblTime.Show();
        }
        private void GameTimer_Tick(object sender, System.EventArgs e)
        {
            secondsPassed += 1;
            lblTime.Text = secondsPassed.ToString();

        }


        // ****************
        // Public Functions
        // ****************


        // ****************
        // Private Functions
        // ****************
    }
}
