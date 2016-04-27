using System;
using Sudoku;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SudokuTests
{
    [TestClass]
    public class BoardTests
    {
        Board board1 = new Board();


        /// <summary>
        /// Test Method will check all Squares on the Board have a valid (numeric - int) value in the FinalValue property set. 
        /// Sqaure.FinalValue() contains the value calculated by the system.
        /// </summary>
        [TestMethod]
        public void AssertSudokuBoardIsFull()
        {
            board1.PopulateBoard();


            foreach(var sq in board1.Grid)
            {
                Square sd = sq;
                Assert.AreNotEqual(0,sq.FinalValue);
            }


        }

        /// <summary>
        /// SolutionIsValid will check all Square.FinalValue() properties and evaluate the solution to confirm it is in valid state. 
        /// </summary>
        [TestMethod]
        public void SolutionIsValid()
        {


        }

        /// <summary>
        /// Check that a row contains the values 1-9 somewhere 
        /// </summary>
        [TestMethod]
        public void RowIsClean()
        {


        }

        /// <summary>
        /// Check that a column contains the values 1-9 somewhere
        /// </summary>
        [TestMethod]
        public void ColumnIsClean()
        {


        }

        /// <summary>
        /// Test will check the smaller 9 Square Square to assert the values are valid.
        /// </summary>
        [TestMethod]
        public void Small9IsClean()
        {

        }

    }
}
