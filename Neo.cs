using System;

namespace Neo
{

    class Program
    {
        /// <summary>
        // Read an M 5 x 5 matrix, calculate and write the following sums:
        // a) from line 3 of M
        // b) from column 2 of M
        // c) the main diagonal
        //d) the secondary diagonal
        // e) of all matrix elements

        /// </summary>
        /// <param name="args"></param>
        ///

        static Random r = new Random();
        static void Main(string[] args)
        {
            int rows = 5;
            int cols = 5;

            int[,] matrix = new int[rows, cols];
            ReadMatrix(matrix);
            PrintMatrix(matrix);
            Console.WriteLine("");
            Console.WriteLine("Sum Row 3 : " + SumRow(matrix, 3));
            Console.WriteLine("Sum Col 2 : " + SumCol(matrix, 2));
            Console.WriteLine("Sum Diagonal : " + SumMainDiagonal(matrix));
            Console.WriteLine("Sum Secondary Diagonal : " + SumSecondaryDiagonal(matrix));



        }
        static void PrintMatrix(int [,]m)
        {
            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {

                    Console.Write(m[row, col]);
                  //  Console.Write("\t");
                }
                Console.Write("\n");
            }

        }
        static void ReadMatrix(int[,] m)
        {
            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {

                    m[row, col] = r.Next(1, 10);
                }
            }
        }
        static int SumRow(int[,] m, int row)
        {
            //row is the index

            int sum = 0;
            for (int col = 0; col < m.GetLength(1); col++)
            {
                sum += m[row, col];

            }
            return sum;
        }

        static int SumCol(int[,] m, int col)
        {
            //col is the index
            int sum = 0;
            for (int row = 0; row < m.GetLength(0); row++)
            {
                sum += m[row, col];

            }
            return sum;
        }

        static int SumMainDiagonal(int[,] m)
        {
            int sum = 0;
            for (int row = 0; row < m.GetLength(0); row++)
            {
                sum += m[row, row];

            }
            return sum;
        }

        static int SumSecondaryDiagonal(int[,] m)
        {
            int sum = 0;
            for (int row = 0; row < m.GetLength(0); row++)
            {
                sum += m[row, m.GetLength(0)-1-row];

            }
            return sum;
        }
    }
}
