using System;

namespace _3_by_3_array
{
    class Program
    {   // Determinant of a 3 by 3 Matix
        static void Main(string[] args)
        {
            int r, g;
            int[,] matrixA = new int[10, 10];
            int mA = 0;


            Console.WriteLine("The determinant of a 3x3 matrix is");
            Console.Write("-------------------------------------------");
            Console.WriteLine("input elements of array");
            for (r = 0; r < 3; r++)
            {
                for (g = 0; g < 3; g++)
                {
                    Console.Write("The element [{0}],[{1}]: ", r, g);
                    matrixA[r, g] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("The matrix below: ");
            for (r = 0; r < 3; r++)
            {
                for (g = 0; g < 3; g++)
                    Console.WriteLine("{0}", matrixA[r,g]);
            }
            for (r=0; r<3; r++)
            {
                mA = mA + (matrixA[0, r] * (matrixA[1, (r + 1) % 3] * matrixA[2, (r + 2) % 3] - matrixA[1, (r + 2)%3] * matrixA[2, (r + 1)%3]));
                Console.WriteLine("The determinant of 3x3 matrix is {0} ",mA);
            }
            Console.ReadLine();
        }
    }
}
