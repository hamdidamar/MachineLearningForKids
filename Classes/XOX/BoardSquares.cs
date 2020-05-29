using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    public class BoardSquares
    { 
        private int playerRound;
        private char [] playerLetters;

        public static BoardSquaresElement [] boardSquares;

        private ConformanceTester conformanceTester;
        

        public BoardSquares()
        {
            boardSquares = new BoardSquaresElement[9];
            conformanceTester = new ConformanceTester();

            CreateBoard();
        }


        public int PlayToSquare(int squareNum)
        {

            boardSquares[squareNum-1].positionSymbol = playerLetters[playerRound];

            if (StatementTester(squareNum)) { return playerRound + 1; }
            else
            {
                playerRound = (playerRound + 1) % 2;
                return 0;
            }
            
        }

        private bool StatementTester(int squareNum)
        {

            if (conformanceTester.HorizontalTester(squareNum, playerLetters[playerRound])) return true;
            else if (conformanceTester.VerticalTester(squareNum, playerLetters[playerRound])) return true;
            else if (conformanceTester.LeftDiagonalTester(squareNum, playerLetters[playerRound])) return true;
            else if (conformanceTester.RightDiagonalTester(squareNum, playerLetters[playerRound])) return true;
            else return false;
        }

        private void CreateBoard()
        {

            playerRound = 0;

            playerLetters = new char[2] { 'X', 'O' };

            for (int boardRecorder = 0; boardRecorder < boardSquares.Length; boardRecorder++)
                boardSquares[boardRecorder] = new BoardSquaresElement();
        }

    }
}
