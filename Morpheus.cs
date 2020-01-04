using System;

namespace Morpheus
{
    class Program
    {
        /// <summary>
        /// Morpheys
        /// Create and Fill two multidimensional arrays, A( 4, 6)  and B (4, 6) and create:
        // a) a matrix S which is the sum of A and B. (A+ B)
        // b) a matrix D that is the difference from A and B. (A - B).
        // Write matrices S and D after all calculations are completed
        /// </summary>
        /// <param name="args"></param>

        static Random r = new Random();
        static void Main(string[] args)
        {
            int rows = 4;
            int cols = 6;

            int[,] matrixA = new int[rows, cols];
            int[,] matrixB = new int[rows, cols];

            ReadMatrix(matrixA);
            ReadMatrix(matrixB);


            Console.WriteLine(" A Matrix");
            PrintMatrix(matrixA);
            Console.WriteLine("");

            Console.WriteLine(" B Matrix");
            PrintMatrix(matrixB);
            Console.WriteLine("");

            Console.WriteLine(" A+B Matrix");
            PrintMatrix(SumMatrixs(matrixA,matrixB));
            Console.WriteLine("");

            Console.WriteLine(" A-B Matrix");
            PrintMatrix(SubtractMatrixs(matrixA, matrixB));
            Console.WriteLine("");




        }
        static int[,] SumMatrixs(int[,] mA, int[,] mB)
        {
            int[,] matrix = new int[mA.GetLength(0), mA.GetLength(1)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = mA[row, col] + mB[row, col];
                }
            }

           return matrix;

        }
        static int[,] SubtractMatrixs(int[,] mA, int[,] mB)
        {
            int[,] matrix = new int[mA.GetLength(0), mA.GetLength(1)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = mA[row, col] - mB[row, col];
                }
            }

            return matrix;

        }
        static void PrintMatrix(int[,] m)
        {
            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {

                    Console.Write(m[row, col]);
                    Console.Write("\t");
                }
                Console.Write("\n");
            }

        }
        static void ReadMatrix(int[,] m)
        {
            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(0); col++)
                {

                    m[row, col] = r.Next(1, 10);
                }
            }
        }
    }
}
