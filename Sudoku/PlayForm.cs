using System;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class PlayForm : Form
    {
        public Difficulty Difficulty { get; set; }
        private int secondsPassed;

        public PlayForm()
        {
            InitializeComponent();
        }
        

        // ***************
        // Event Handlers
        // ***************
        private void PlayForm_Load(object sender, EventArgs e)
        {
            GameBoard.Enabled = false;
            secondsPassed = 0;
        }
        private void PlayBtnClick(object sender, System.EventArgs e)
        {
            // generate FinalValues of each square 

            // start timer display in label
            GameTimer.Start();


            // hide button
            PlayBtn.Hide();
            lblTime.Show();
            GameBoard.Enabled = true;
            GameBoard.Difficulty = Difficulty;

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
