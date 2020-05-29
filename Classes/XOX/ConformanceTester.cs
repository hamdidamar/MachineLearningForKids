using GameBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    public class ConformanceTester
    {
        private BoardSquaresElement[] boardRows;
        private RowTaker rowTaker;
        public ConformanceTester()
        {
            rowTaker = new RowTaker();
            
        }
        public bool VerticalTester(int positionNumber, char playerLetter)
        {
            boardRows = rowTaker.VerticalTake(positionNumber);

            if (boardRows == null) return false;
            else return (playerLetter == boardRows[0].positionSymbol && playerLetter == boardRows[1].positionSymbol && playerLetter == boardRows[2].positionSymbol);
        }
        public bool HorizontalTester(int positionNumber, char playerLetter)
        {
            boardRows = rowTaker.HorizontalTake(positionNumber);

            if (boardRows == null) return false;
            else return (playerLetter == boardRows[0].positionSymbol && playerLetter == boardRows[1].positionSymbol && playerLetter == boardRows[2].positionSymbol);
        }
        public bool LeftDiagonalTester(int positionNumber, char playerLetter)
        {
            boardRows = rowTaker.LeftDiagonalTake(positionNumber);

            if (boardRows == null) return false;
            else return (playerLetter == boardRows[0].positionSymbol && playerLetter == boardRows[1].positionSymbol && playerLetter == boardRows[2].positionSymbol);
        }
        public bool RightDiagonalTester(int positionNumber, char playerLetter)
        {
            boardRows = rowTaker.RightDiagonalTake(positionNumber);

            if (boardRows == null) return false;
            else return (playerLetter == boardRows[0].positionSymbol && playerLetter == boardRows[1].positionSymbol && playerLetter == boardRows[2].positionSymbol);
        }

    }
}
