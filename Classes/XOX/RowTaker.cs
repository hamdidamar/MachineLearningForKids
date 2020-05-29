using GameBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    public class RowTaker
    {
        private BoardSquaresElement [] boardElement;


        private int headPosition;

        public RowTaker()
        {
            boardElement = new BoardSquaresElement[3];
        }

        public BoardSquaresElement[] HorizontalTake(int positionNumber)
        {
            headPosition = positionNumber - Convert.ToInt16(positionNumber % 3.0001);

            boardElement[0] = BoardSquares.boardSquares[headPosition];
            boardElement[1] = BoardSquares.boardSquares[headPosition + 1];
            boardElement[2] = BoardSquares.boardSquares[headPosition + 2];

            return boardElement;
        }
        
        public BoardSquaresElement[] VerticalTake(int positionNumber)
        {
            headPosition = Convert.ToInt16(positionNumber % 3.0001)-1;

            boardElement[0] = BoardSquares.boardSquares[headPosition];
            boardElement[1] = BoardSquares.boardSquares[headPosition + 3];
            boardElement[2] = BoardSquares.boardSquares[headPosition + 6];

            return boardElement;
        }

        public BoardSquaresElement[] LeftDiagonalTake(int positionNumber)
        {
            if(positionNumber % 4 == 1)
            {
                boardElement[0] = BoardSquares.boardSquares[0];
                boardElement[1] = BoardSquares.boardSquares[4];
                boardElement[2] = BoardSquares.boardSquares[8];

                return boardElement;
            }

            return null;
        }

        public BoardSquaresElement[] RightDiagonalTake(int positionNumber)
        {       //Because 5. square has two diagonals.
            if (positionNumber % 4 == 3 || positionNumber == 5)
            {
                boardElement[0] = BoardSquares.boardSquares[2];
                boardElement[1] = BoardSquares.boardSquares[4];
                boardElement[2] = BoardSquares.boardSquares[6];

                return boardElement;
            }

            return null;
        }
    }
}
