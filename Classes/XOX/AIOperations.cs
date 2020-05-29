using GameBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAI
{
    public class AIOperations
    {
        StatusEvalutionCalculater aIStatusCalculator;
        StatusEvalutionCalculater humanStatusCalculator;
        private readonly char m_aIMoveSymbol;

        public AIOperations(char aIMoveSymbol, char humanMoveSymbol)
        {
            m_aIMoveSymbol = aIMoveSymbol;
           // m_boardSquares = boardSquares;
            aIStatusCalculator = new StatusEvalutionCalculater(aIMoveSymbol, humanMoveSymbol);
            humanStatusCalculator = new StatusEvalutionCalculater(humanMoveSymbol, aIMoveSymbol);

        }

        public int MakeMove(int fallibilityRate)
        {
            int aIMoveSquareNum = FindBestStatusMove(fallibilityRate);
            //m_boardSquares.PlayToSquare(aIMoveSquareNum);
            return aIMoveSquareNum;
        }

        private List<int> FindPlayableMoves()
        {
            List<int> playableSquares = new List<int>();

            for (int squareRecorder = 0; squareRecorder < 9; squareRecorder++)
            {
                if (BoardSquares.boardSquares[squareRecorder].positionSymbol == ' ')
                    playableSquares.Add(squareRecorder);
            }
            return playableSquares;

        }

        private int TakeFallibilityRate()
        {
            Random successRater = new Random();
            int successRate = 0;

            successRate = successRater.Next(0, 100);
            return successRate;
        }

        private int FindBestStatusMove(int fallibilityRate)
        {

            List<int> playableSquares = FindPlayableMoves();

            int bestMoveValue = 999;
            int bestMove = playableSquares[0]+1;

            for (int moveRecorder = 0; moveRecorder < playableSquares.Count; moveRecorder++)
            {
                if (fallibilityRate < TakeFallibilityRate())
                {
                    int currentMoveValue = FindStatus(playableSquares[moveRecorder]);
                    if (bestMoveValue > currentMoveValue)
                    {
                        bestMove = playableSquares[moveRecorder] + 1;
                        bestMoveValue = currentMoveValue;
                    }
                }

                else continue;
            }
            return bestMove;

        }

        private int FindStatus(int movePosition)
        {
            char squareSymbol = BoardSquares.boardSquares[movePosition].positionSymbol;
            BoardSquares.boardSquares[movePosition].positionSymbol = m_aIMoveSymbol;

            int statusValue = humanStatusCalculator.CalculateStatus() - aIStatusCalculator.CalculateStatus();
            Console.WriteLine("STATUS:" + humanStatusCalculator.CalculateStatus() + aIStatusCalculator.CalculateStatus()+"\n");
            BoardSquares.boardSquares[movePosition].positionSymbol = squareSymbol;

            return statusValue;
        }
    }
}

