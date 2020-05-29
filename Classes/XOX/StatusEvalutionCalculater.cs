using GameBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAI
{
    public class StatusEvalutionCalculater
    {
        readonly char m_playerSymbol;
        readonly char m_opponentSymbol;
        readonly RowTaker m_rowTaker;
        private BoardSquaresElement[] boardRows;

        public StatusEvalutionCalculater(char playerSymbol, char opponentSymbol)
        {
            m_opponentSymbol = opponentSymbol;
            m_playerSymbol = playerSymbol;
            m_rowTaker = new RowTaker();
            boardRows = new BoardSquaresElement[3];

        }

        public int CalculateStatus()
        {
            return CalculateDiagonalsStatus() + CalculateHorizontalStatus() + CalculateVerticalStatus();
        }

        private int CalculateHorizontalStatus()
        {
            int matchableSquaresValue = 0;

            boardRows = m_rowTaker.HorizontalTake(1);

            matchableSquaresValue += MatchableValue();

            boardRows = m_rowTaker.HorizontalTake(4);

            matchableSquaresValue += MatchableValue();

            boardRows = m_rowTaker.HorizontalTake(7);

            matchableSquaresValue += MatchableValue();

            return matchableSquaresValue;
        }

        private int CalculateVerticalStatus()
        {
            int matchableSquaresValue = 0;
            boardRows = m_rowTaker.VerticalTake(1);

            matchableSquaresValue += MatchableValue();

            boardRows = m_rowTaker.VerticalTake(2);

            matchableSquaresValue += MatchableValue();

            boardRows = m_rowTaker.VerticalTake(3);

            matchableSquaresValue += MatchableValue();

            return matchableSquaresValue;
        }

        private int CalculateDiagonalsStatus()
        {
            int matchableSquaresValue = 0;
            boardRows = m_rowTaker.LeftDiagonalTake(1);

            matchableSquaresValue += MatchableValue();


            boardRows = m_rowTaker.RightDiagonalTake(3);

            matchableSquaresValue += MatchableValue();


            return matchableSquaresValue;
        }

        private int MatchableValue()
        {
            if (HasPlayerMatched3Rows()) return 999;
            else if (HasPlayerMatchable3Rows()) return 99;
            else if (!HasOpponentSymbolIn3Rows()) return 1;
            else return 0;
        }

        private bool HasOpponentSymbolIn3Rows()
        {
            return boardRows[0].positionSymbol == m_opponentSymbol || boardRows[1].positionSymbol == m_opponentSymbol || boardRows[2].positionSymbol == m_opponentSymbol;
        }

        private bool HasPlayerMatched3Rows()
        {
            return boardRows[0].positionSymbol == m_playerSymbol && boardRows[1].positionSymbol == m_playerSymbol && boardRows[2].positionSymbol == m_playerSymbol;
        }

        private bool HasPlayerMatchable3Rows()
        {
            return HasPlayer2Of3Rows() && !HasOppenent1Of3Rows();
        }

        private bool HasPlayer2Of3Rows()
        {
            int matchNum = 0;

            foreach (var rowSymbol in boardRows)
            {
                if (rowSymbol.positionSymbol == m_playerSymbol) matchNum++;
            }

            if (matchNum == 2) return true;
            else return false;
        }

        private bool HasOppenent1Of3Rows()
        {
            foreach (var rowSymbol in boardRows)
            {
                if (rowSymbol.positionSymbol == m_opponentSymbol) return true;
            }

            return false;
        }

    }
}
