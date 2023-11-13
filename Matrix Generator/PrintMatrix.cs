using System;
namespace Matrix
{
    public class Print
    {
        public static void Matrix(int[,] matrixReg) // matrix print function
        {
            int rows = matrixReg.GetLength(0);
            int cols = matrixReg.GetLength(1);

            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrixReg[i, j]}\t");
                }

                Console.WriteLine();
            }
        }
    }
}