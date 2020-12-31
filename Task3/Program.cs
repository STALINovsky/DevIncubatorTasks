using System;
using System.Linq;
using System.Text;
using System.Linq;

namespace Task3
{
    class Program
    {
        /// <summary>
        /// Create Multiplication matrix, where matrix [i,j] = i * j;
        /// </summary>
        /// <param name="dimension"></param>
        /// <returns>Multiplication matrix</returns>
        static int[,] CreateMultiplicationTable(int dimension)
        {
            int[,] matrix = new int[dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    
                    matrix[i, j] = (i + 1) * (j + 1);
                }
            }

            return matrix;
        }
        /// <summary>
        /// Print square matrix to console
        /// </summary>
        /// <param name="matrix"></param>
        static void PrintTable(int[,] matrix)
        {
            var rowsCount = matrix.GetUpperBound(0) + 1;
            var columnsCount = matrix.Length / rowsCount;

            StringBuilder stringBuilder = new();

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    stringBuilder.Append($"{matrix[i, j],3}");
                }

                stringBuilder.AppendLine();
            }

            Console.WriteLine(stringBuilder.ToString());
        }

        static void Main(string[] args)
        {
            var matrix = CreateMultiplicationTable(9);
            PrintTable(matrix);
        }
    }
}
