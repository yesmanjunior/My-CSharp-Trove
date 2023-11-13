using System;

namespace Matrix
{
    public static class Shenanigans
    {
        static void Main()
        {
            Console.Write("Input your row quantity: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input your column quantity: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input your value range: ");
            Config.range = Convert.ToInt32(Console.ReadLine());

            int[,] generatedMatrix = Generate.Matrix(rows, cols);

            Console.WriteLine("\nGenerated Matrix:\n");
            Print.Matrix(generatedMatrix);

            Console.Write("\nShow the transposed matrix? (Y/N): ");
            string input = Console.ReadLine() ?? "";

            char choice = Char.ToUpper(Convert.ToChar(input));

            if (choice == 'Y' || choice == 'y')
            {
                int[,] transposedMatrix = Transpose.MatrixT(generatedMatrix);

                Console.WriteLine("\nTransposed Matrix: \n");
                Print.Matrix(transposedMatrix);
            }

            else if (choice == 'N' || choice == 'n') {Console.Write("");}
            Console.WriteLine("\nThanks for using me, come again!");
           
            Console.Write("Press a key to exit...");
            Console.ReadKey();
        }
    }
}
