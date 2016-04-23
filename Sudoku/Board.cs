using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Board : UserControl
    {
        private List<Square> selectedRow = new List<Square>();
        private List<Square> selectedColumn = new List<Square>();
        private List<Square> selectedSquare = new List<Square>();

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

        private void SquareValidation(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


        // ***************************
        // Private Functions
        // ***************************


    }
}
