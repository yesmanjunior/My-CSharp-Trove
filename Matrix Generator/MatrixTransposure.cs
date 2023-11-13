using System;
namespace Matrix
{
    public class Transpose
    {
        public static int[,] MatrixT(int[,] matrixReg) // transposed matrix
        {
            int rowsT = matrixReg.GetLength(0);
            int colsT = matrixReg.GetLength(1);

            int[,] matrixT = new int[colsT, rowsT]; // transposed columns and rows respectively

            for (int i = 0; i < rowsT; i++)
            {

                for (int j = 0; j < colsT; j++)
                {
                    matrixT[j, i] = matrixReg[i, j];
                }
            }

            return matrixT;
        }
    }
}