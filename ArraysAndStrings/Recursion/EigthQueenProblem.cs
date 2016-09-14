using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    //You have an 8x8 chessboard, find a placement of 8 queens on the
    //board so that no queen is able to atack another queen
    //Example:
    //0 0 1 0
    //1 0 0 0
    //0 0 0 1
    //0 1 0 0
    public class EigthQueenProblem
    {
        private static int[,] _board;
        private int _numQueens;
        private readonly int _totalNumberOfQueens;
        private int _cnt = 0;

        public EigthQueenProblem(int totalNumberOfQueens = 8, int sizeOfBoard = 8)
        {
            _totalNumberOfQueens = totalNumberOfQueens;
            _numQueens = 0;
            _board = new int[sizeOfBoard, sizeOfBoard];
            for (int i = 0; i < _board.GetLength(0); ++i)
            {
                for (int j = 0; j < _board.GetLength(1); ++j)
                {
                    _board[i, j] = 0;
                }
            }
        }

        public bool Solve()
        {
            PrintBoard();
            if (_numQueens == _totalNumberOfQueens)
            {
                PrintBoard();
                return true;
            }
            for (int i = 0; i < _board.GetLength(0); ++i)
            {
                for (int j = 0; j < _board.GetLength(1); ++j)
                {
                    ++_cnt;
                    if (ValidMove(i, j))
                    {
                        PlaceQueen(i, j, true);
                        _numQueens++;
                        if (Solve())
                        {
                            return true;
                        }
                        PlaceQueen(i, j, false);
                        _numQueens--;
                    }
                }
            }
            return false;
        }

        private int PlaceQueen(int x, int y, bool validMove)
        {
            if (validMove)
            {
                _board[x, y] = 1;
                return 0;
            }
            _board[x, y] = 0;
            return 0;
        }

        private bool ValidMove(int x, int y)
        {
            for (int k = 0; k < _board.GetLength(1); ++k)
            {
                ++_cnt;
                if (Get(x, k) || Get(k, y))
                {
                    return false;
                }
                if (Get(x - k, y - k) || Get(x - k, y + k) || Get(x + k, y - k) || Get(x + k, y + k))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool Get(int x, int y)
        {
            if (x < 0 || x >= _board.GetLength(0) || y < 0 || y >= _board.GetLength(1))
            {
                return false;
            }
            return _board[x, y] == 1;
        }

        private void PrintBoard()
        {
            for (int i = 0; i < _board.GetLength(0); ++i)
            {
                for (int j = 0; j < _board.GetLength(1); ++j)
                {
                    Console.Write(_board[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("cnt = " + _cnt + " --------------------------------");
        }
    }
}
