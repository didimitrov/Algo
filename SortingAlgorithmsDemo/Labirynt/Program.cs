
using System;

namespace Labirynt
{
    class Program
    {
       static char[,] _lab =
                        {
                            {' ', ' ', ' ', '*', ' ', ' ', ' '},
                            {'*', '*', ' ', '*', ' ', '*', ' '},
                            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                            {' ', '*', '*', '*', '*', '*', ' '},
                            {' ', ' ', ' ', ' ', ' ', ' ', 'е'},
                        };

        static void FindPath(int row, int col)
        {
            if (row < 0 || col < 0 || col >= _lab.GetLength(1) || row >= _lab.GetLength(0))
            {
                return;
            }
            if (_lab[row, col]=='e')
            {
                Console.WriteLine("Found exit!");
            }
            if (_lab[row, col] != ' ')
            {
                return;
            }

            _lab[row, col] = 's';

            FindPath(row, col + 1);
            FindPath(row+1, col);
            FindPath(row-1, col);
            FindPath(row, col - 1);

            _lab[row, col] = ' ';

        }
        private static void Main(string[] args)
        {
        
        }
    }
}
