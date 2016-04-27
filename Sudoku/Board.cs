using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Board : UserControl
    {
        // Public members
        public Difficulty Difficulty;
        public List<Square> Grid;

        // Private variables
        private Modes _mode;
        private Square selectedSquare;
        private List<Square> selectedRow;
        private List<Square> selectedColumn;
        private List<Square> selected9;
        private List<List<Square>> sub9Squares;
        
        public Board()
        {
            InitializeComponent();
            _mode = Modes.PreStart;
            Grid = MainPanel.Controls.OfType<Square>().ToList();

            // populate the sub 9 square lists
            sub9Squares = new List<List<Square>>();
            
            // Hardcode the values of the corresponding SubSquares, add them to List of Lists
            List<Square> first = new List<Square> {x1y1,x2y1,x3y1, x1y2,x2y2,x3y2, x1y3,x2y3,x3y3};
            List<Square> second = new List<Square> {x4y1,x5y1,x6y1, x4y2,x5y2,x6y2, x4y3,x5y3,x6y3};
            List<Square> third = new List<Square> {x7y1,x8y1,x9y1, x7y2,x8y2,x9y2, x7y3,x8y3,x9y3};
            List<Square> fourth = new List<Square> {x1y4,x2y4,x3y4, x1y5,x2y5,x3y5, x1y6,x2y6,x3y6};
            List<Square> fifth = new List<Square> {x4y4,x5y4,x6y4, x4y5,x5y6,x6y5, x4y6,x5y6,x6y6};
            List<Square> sixth = new List<Square> {x7y4,x8y4,x9y4, x7y5,x8y5,x9y5, x7y6,x8y6,x9y6 };
            List<Square> seventh = new List<Square> {x1y7,x2y7,x3y7, x1y8,x2y8,x3y8, x1y9,x2y9,x3y9};
            List<Square> eigth = new List<Square> {x4y7,x5y7,x6y7, x4y8,x5y8,x6y8, x4y9,x5y9,x6y9};
            List<Square> ninth = new List<Square> {x7y7,x8y7,x9y7, x7y8,x8y8,x9y8, x7y9,x8y9,x9y9};
            sub9Squares.Add(first);
            sub9Squares.Add(second);
            sub9Squares.Add(third);
            sub9Squares.Add(fourth);
            sub9Squares.Add(fifth);
            sub9Squares.Add(sixth);
            sub9Squares.Add(seventh);
            sub9Squares.Add(eigth);
            sub9Squares.Add(ninth);
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
            
        }
        public void PopulateBoard()
        {
            //// based on Difficulty the board will populate and display a certain amount of values, while leaving the rest to the user.
            //if (SolveSudoku(Grid))
            //{
            //    Console.WriteLine("Solved");
            //}
            //else
            //    Console.WriteLine("Fucked");



            AssignSmaller9(0);
            AssignSmaller9(1);
            AssignSmaller9(2);
            AssignSmaller9(3);
            ShowValues();
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
            List<Square> retColumn = new List<Square>();
            string xPos = sq.Name[1].ToString();
            string yPos = sq.Name[3].ToString();

            for (int i = 1; i < 10; ++i)
            {
                Square temp;
                string sqToGet = "x" + xPos + "y" + i;
                temp = (Square)this.MainPanel.Controls[sqToGet];
                retColumn.Add(temp);
            }
            return retColumn;

        }
        private List<Square> buildSelected9(Square sq)
        {
            List<Square> ret9 = null;
            
            foreach(List<Square> list in sub9Squares)
            {
                if (list.Contains(sq))
                    ret9 = list;
            }

            return ret9;
        }

        private bool ValueIsUsedInRow(Square square, int value)
        {
            bool retValue = false;
            // Build the row and check it.
            List<Square> theRowInQuestion = buildSelectedRow(square);
            foreach (Square sq in theRowInQuestion)
            {
                if (sq.FinalValue == value)
                    retValue = true;
            }
            return retValue;
        }
        private bool ValueIsUsedInColumn(Square square, int value)
        {
            bool retValue = false;
            // Build the column and check it.
            List<Square> theColumnInQuestion = buildSelectedColumn(square);
            foreach (Square sq in theColumnInQuestion)
            {
                if (sq.FinalValue == value)
                    retValue = true;
            }
            return retValue;
        }
        private bool ValueIsUsedIn9(Square square, int value)
        {
            bool retValue = false;
            // Build the column and check it.
            List<Square> the9InQuestion = buildSelected9(square);
            foreach (Square sq in the9InQuestion)
            {
                if (sq.FinalValue == value)
                    retValue = true;
            }
            return retValue;
        }

        /// <summary>
        /// Returns True if there is still an unassigned location somewhere in the List of Squares
        /// </summary>
        /// <param name="grid">Represents the List of Squares to be passed in.. usually will be the grid, could be anything.</param>
        /// <returns></returns>
        private bool FindUnassignedLocation(List<Square> grid)
        {
            foreach (Square sq in grid)
            {
                if (sq.FinalValue == null || sq.FinalValue == 0)
                    return true;
            }
            return false;
        }

        // recursive function to assign the grid with values 
        // When it finally returns true the board has been filled
        private bool SolveSudoku(List<Square> grid)
        {
            int count = 0;
            foreach (Square sq in grid)
            {
                count++;
                if (count > 5000)
                    return false;
                for (int i = 1; i <= 9; ++i)
                {
                    //Search grid for unassigned square
                    if (!FindUnassignedLocation(grid))
                        return true;

                    // Create Bool's to represent whether the value (iteration #) is used elsewhere in corresponding containers
                    bool isUsedInRow = ValueIsUsedInRow(sq,i);
                    bool isUsedIn9 = ValueIsUsedIn9(sq,i);
                    bool isUsedInColumn = ValueIsUsedInColumn(sq, i);
                    
                    //if it looks promising aka, value is not assigned anywhere else in row, column or smaller9
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
        
        /// <summary>
        /// Will Display the FinalValues set by the sytem in the respective Squares.
        /// </summary>
        private void ShowValues()
        {
            foreach(Square sq in Grid)
            {
                sq.SetFinalValue();
            }
        }

        /// <summary>
        /// A little creative thinking can go a long way..
        /// </summary>
        private void HomemadePopulate()
        {




        }


        /// <summary>
        /// Function will populate the smaller 9 square will random values
        /// </summary>
        /// <param name="i">i represents the number of the smaller grid to be populated</param>
        /// |1|1|1|2|2|2|3|3|3|
        /// |1|1|1|2|2|2|3|3|3|
        /// |1|1|1|2|2|2|3|3|3|
        /// |4|4|4|5|5|5|6|6|6|
        /// |4|4|4|5|5|5|6|6|6|
        /// |4|4|4|5|5|5|6|6|6|
        /// |7|7|7|8|8|8|9|9|9|
        /// |7|7|7|8|8|8|9|9|9|
        /// |7|7|7|8|8|8|9|9|9|
        /// 
        private void AssignSmaller9(int i)
        {
            // Get a new random instance
            Random rnd = new Random();
            
            switch(i)
            {
                // 0 Handles random case.
                case 0:
                    {
                        // Grab a Random 9 Square
                        int rnd9 = rnd.Next(8);
                        List<Square> the9 = sub9Squares[rnd9];
                                                
                        // populate them with random values based off of what else is in the square
                        foreach (Square sq in the9)
                        {
                            List<int> valuesItCantBe = new List<int>();

                            // Construct selected row, column, and temp9 to compare their values and add them to List if they can't be used here.
                            List<Square> row = buildSelectedRow(sq);
                            List<Square> column = buildSelectedColumn(sq);
                            List<Square> temp9 = buildSelected9(sq);

                            // iterate through a loop 9 times and check the index of the row, column and selected9 to populate the list of values it cant be
                            for (int j=0;j<9;++j)
                            {
                                if (temp9[j].FinalValue != null && temp9[j].FinalValue != 0)
                                    valuesItCantBe.Add((int)temp9[j].FinalValue);

                                if (row[j].FinalValue != null && row[j].FinalValue != 0)
                                    valuesItCantBe.Add((int)row[j].FinalValue);

                                if (column[j].FinalValue != null && column[j].FinalValue != 0)
                                    valuesItCantBe.Add((int)column[j].FinalValue);
                            }


                            // represents a random value we will try to assign this square
                            int rndValue;
                            do
                            {
                                rndValue = rnd.Next(1, 10);
                            } while (valuesItCantBe.Contains(rndValue));
                            
                            // if the sqaure doesn't have a value, we select it, 
                            // otherwise it's populated and we don't need to worry about it
                            if (sq.FinalValue == 0 || sq.FinalValue == null)
                                sq.FinalValue = rndValue;
                            else
                                continue;
                        }
                        break;
                    }
                case 1:
                    {
                        List<Square> the9 = sub9Squares[0];
                        // populate them with random values based off of what else is in the square
                        foreach (Square sq in the9)
                        {
                            List<int> valuesItCantBe = new List<int>();

                            // Construct selected row, column, and temp9 to compare their values and add them to List if they can't be used here.
                            List<Square> row = buildSelectedRow(sq);
                            List<Square> column = buildSelectedColumn(sq);
                            List<Square> temp9 = buildSelected9(sq);

                            // iterate through a loop 9 times and check the index of the row, column and selected9 to populate the list of values it cant be
                            for (int j = 0; j < 9; ++j)
                            {
                                if (temp9[j].FinalValue != null && temp9[j].FinalValue != 0)
                                    valuesItCantBe.Add((int)temp9[j].FinalValue);

                                if (row[j].FinalValue != null && row[j].FinalValue != 0)
                                    valuesItCantBe.Add((int)row[j].FinalValue);

                                if (column[j].FinalValue != null && column[j].FinalValue != 0)
                                    valuesItCantBe.Add((int)column[j].FinalValue);
                            }


                            // represents a random value we will try to assign this square
                            int rndValue;
                            do
                            {
                                rndValue = rnd.Next(1, 10);
                            } while (valuesItCantBe.Contains(rndValue));

                            // if the sqaure doesn't have a value, we select it, 
                            // otherwise it's populated and we don't need to worry about it
                            if (sq.FinalValue == 0 || sq.FinalValue == null)
                                sq.FinalValue = rndValue;
                            else
                                continue;
                        }
                        break;
                    }
                case 2:
                    {
                        List<Square> the9 = sub9Squares[1];
                        // populate them with random values based off of what else is in the square
                        foreach (Square sq in the9)
                        {
                            List<int> valuesItCantBe = new List<int>();

                            // Construct selected row, column, and temp9 to compare their values and add them to List if they can't be used here.
                            List<Square> row = buildSelectedRow(sq);
                            List<Square> column = buildSelectedColumn(sq);
                            List<Square> temp9 = buildSelected9(sq);

                            // iterate through a loop 9 times and check the index of the row, column and selected9 to populate the list of values it cant be
                            for (int j = 0; j < 9; ++j)
                            {
                                if (temp9[j].FinalValue != null && temp9[j].FinalValue != 0)
                                    valuesItCantBe.Add((int)temp9[j].FinalValue);

                                if (row[j].FinalValue != null && row[j].FinalValue != 0)
                                    valuesItCantBe.Add((int)row[j].FinalValue);

                                if (column[j].FinalValue != null && column[j].FinalValue != 0)
                                    valuesItCantBe.Add((int)column[j].FinalValue);
                            }


                            // represents a random value we will try to assign this square
                            int rndValue;
                            do
                            {
                                rndValue = rnd.Next(1, 10);
                            } while (valuesItCantBe.Contains(rndValue));

                            // if the sqaure doesn't have a value, we select it, 
                            // otherwise it's populated and we don't need to worry about it
                            if (sq.FinalValue == 0 || sq.FinalValue == null)
                                sq.FinalValue = rndValue;
                            else
                                continue;
                        }
                        break;
                        break;
                    }
                case 3:
                    {
                        List<Square> the9 = sub9Squares[2];
                        // populate them with random values based off of what else is in the square
                        foreach (Square sq in the9)
                        {
                            List<int> valuesItCantBe = new List<int>();

                            // Construct selected row, column, and temp9 to compare their values and add them to List if they can't be used here.
                            List<Square> row = buildSelectedRow(sq);
                            List<Square> column = buildSelectedColumn(sq);
                            List<Square> temp9 = buildSelected9(sq);

                            // iterate through a loop 9 times and check the index of the row, column and selected9 to populate the list of values it cant be
                            for (int j = 0; j < 9; ++j)
                            {
                                if (temp9[j].FinalValue != null && temp9[j].FinalValue != 0)
                                    valuesItCantBe.Add((int)temp9[j].FinalValue);

                                if (row[j].FinalValue != null && row[j].FinalValue != 0)
                                    valuesItCantBe.Add((int)row[j].FinalValue);

                                if (column[j].FinalValue != null && column[j].FinalValue != 0)
                                    valuesItCantBe.Add((int)column[j].FinalValue);
                            }


                            // represents a random value we will try to assign this square
                            int rndValue;
                            do
                            {
                                rndValue = rnd.Next(1, 10);
                            } while (valuesItCantBe.Contains(rndValue));

                            // if the sqaure doesn't have a value, we select it, 
                            // otherwise it's populated and we don't need to worry about it
                            if (sq.FinalValue == 0 || sq.FinalValue == null)
                                sq.FinalValue = rndValue;
                            else
                                continue;
                        }
                        break;
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                case 6:
                    {
                        break;
                    }
                case 7:
                    {
                        break;
                    }
                case 8:
                    {
                        break;
                    }
                case 9:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

        }
    }
}
