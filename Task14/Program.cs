using System;

namespace Task14
{
    class Program
    {
        /// <summary>
        /// Create array. Array element equal to the index of the first element minus the second element's index.
        /// </summary>
        /// <param name="rowsCount">Count of array rows, must be greater than  0 </param>
        /// <param name="columnsCount">Count of array cols, must be greater than  0 </param>
        /// <returns>square squareArray</returns>
        static int[,] CreateSquareArray(int rowsCount, int columnsCount)
        {
            var matrix = new int[rowsCount, columnsCount];

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    matrix[i, j] = i - j;
                }
            }

            return matrix;
        }

        static void Main(string[] args)
        {
            //creating square matrix
            var matrix = CreateSquareArray(3, 5);
            //assign matrix characteristics
            var matrixLength = matrix.Length;
            var matrixDimension = matrix.Rank;

            //calculating sum of matrix elements
            var sumOfMatrixElements = 0;
            foreach (var element in matrix)
            {
                sumOfMatrixElements += element;
            }

            //show matrix characteristics
            Console.WriteLine($"array length = {matrixLength}," +
                              $" array dimension = {matrixDimension}," +
                              $" sum of elements = {sumOfMatrixElements}");
        }
    }
}
