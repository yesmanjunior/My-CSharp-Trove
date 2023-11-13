using System;
namespace Matrix
{
    public class Generate
    {
        public static int[,] Matrix(int rows, int cols)
        {
            Random values = new Random();
            int range = Config.range;
            
            int[,] matrixReg = new int[rows, cols]; // regular matrix

            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < cols; j++)
                {
                    matrixReg[i, j] = values.Next(1, range);
                }
            }

            return matrixReg;
        }
    }
}