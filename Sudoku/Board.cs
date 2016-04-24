using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


//http://www.geeksforgeeks.org/backtracking-set-7-suduku/
namespace Sudoku
{
    public partial class Board : UserControl
    {
        // Public members
        public Difficulty Difficulty;
        
        // Private variables
        private Modes _mode;
        private List<Square> Grid;
        private Square selectedSquare;
        private List<Square> selectedRow;
        private List<Square> selectedColumn;
        private List<Square> selected9;
        private Square[,] array = new Square[8, 8];
        
        public Board()
        {
            InitializeComponent();
            _mode = Modes.PreStart;
            Grid = MainPanel.Controls.OfType<Square>().ToList();

            for (int i = 1; i < 9; ++i)
            {
                for (int j = 1; i < 9; ++j)
                {
                    string s = "x" + i + "y" + j;


                }


            }

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
            selectedSquare = sq;
            // build selected row, column and  9

            
        }
        private void SquareValidation(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Square sq = (Square)sender;
            
             
                 
        }
        
        // ***************************
        // Public Functions
        // ***************************
        public void StartGame()
        {
            switch(Difficulty)
            {
                case Difficulty.Easy:
                    {
                        


                        break;
                    }
                case Difficulty.Medium:
                    {


                        break;
                    }
                case Difficulty.Hard:
                    {


                        break;
                    }
            }
            

            if(SolveSudoku(Grid))
            {
                ShowValues();
            }
        }
        
        // ***************************
        // Private Functions
        // ***************************
        private List<Square> buildSelectedRow(Square sq)
        {
            List<Square> retRow = new List<Square>();
            string xPos = sq.Name[1].ToString();
            string yPos = sq.Name[3].ToString();

            for(int i = 1;i<10;++i)
            {
                Square temp;
                string sqToGet = "x" + i + "y" + yPos;
                temp = (Square)this.MainPanel.Controls[sqToGet];
                retRow.Add(temp);
            }
            return retRow;
        }
        private List<Square> buildSelectedColumn(Square sq)
        {
            List<Square> retRow = new List<Square>();
            string xPos = sq.Name[1].ToString();
            string yPos = sq.Name[3].ToString();

            for (int i = 1; i < 10; ++i)
            {
                Square temp;
                string sqToGet = "x" + xPos + "y" + i;
                temp = (Square)this.MainPanel.Controls[sqToGet];
                retRow.Add(temp);
            }
            return retRow;

        }

        private List<Square> buildSelected9(Square sq)
        {
            List<Square> ret9 = new List<Square>();






            return ret9;
        }

        // recursive function to assign the grid with values 
        // When it finally returns true the board has been filled
        private bool SolveSudoku(List<Square> grid)
        {
            foreach (Square sq in grid)
            {
                for (int i = 1; i <= 9; ++i)
                {
                    //Search grid for unassigned square
                    if (!FindUnassignedLocation(grid))
                        return true;

                    bool isUsedInRow = ValueIsAssigned(buildSelectedRow(sq),i);
                    bool isUsedIn9 = ValueIsAssigned(buildSelected9(sq),i);
                    bool isUsedInColumn = ValueIsAssigned(buildSelectedColumn(sq),i);


                    //if it looks promising aka, value is not assigned anywhere else in row, column or 9
                    if (!isUsedIn9 && !isUsedInColumn && !isUsedInRow)
                    {
                        //make tentative assignment
                        sq.FinalValue = i;

                        // return, if success, we are done
                        if (SolveSudoku(grid))
                            return true;
                        //failure, unmake and try again....
                        sq.FinalValue = 0;
                    }
                }
            }
            return false;
        }

        // returns false if there are no unassigned squares remaining
        private bool FindUnassignedLocation(List<Square> grid)
        {
            foreach (Square sq in grid)
            {
                if (sq.FinalValue == null || sq.FinalValue == 0)
                    return true;
            }
            return false;
        }


        // Check a list of Squares to see if the value passed in has been assigned somewhere in the list
        private bool ValueIsAssigned(List<Square> squares, int value)
        {
            foreach (Square s in squares)
            {
                if (s.FinalValue == value)
                    return true;
            }

            return false;
        }




        private void ShowValues()
        {
            foreach(Square sq in Grid)
            {
                sq.SetFinalValue();
            }
        }
    }
}
