using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Board : UserControl
    {
        public enum modes { PreStart,Started,InProgress,Finished};
        private List<Square> selectedRow = new List<Square>();
        private List<Square> selectedColumn = new List<Square>();
        private List<Square> selectedSquare = new List<Square>();
        private string Difficulty = "Easy";

        public Board()
        {
            InitializeComponent();
        }
        // **************************
        // Event Handlers
        // **************************
        private void Board_Load(object sender, EventArgs e)
        {
         


        }
        private void SquareEnter(object sender, EventArgs e)
        {
            Square sq = (Square)sender;

        }



        // ***************************
        // Public Functions
        // ***************************
        public void StartGame()
        {

        }


        // ***************************
        // Private Functions
        // ***************************

        private bool RowIsValid()
        {
            bool retValue = false;

            // Determine if a Row contains values 1 through 9 and no duplicates. 




            return retValue;
        }
        
    }
}
