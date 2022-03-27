using System;

namespace Multilply_matrix
{
    class Program
    {   // MULTIPLICATION OF A 3 BY 3 MATRIX
        static void Main(string[] args)
        {
            // input the total row and columns of the matrix
            int a, b, r, c;
            Console.WriteLine("Enter the total row and column");
            r = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            int[,] d = new int[r, c];

            // input the values of the first matrix
            Console.WriteLine("Enter the First Matrix");
            for (a = 0; a < r; a++)
            {
                for (b = 0; b < c; b++)
                {
                    d[a, b] = int.Parse(Console.ReadLine());
                }

            }
            //print out the value of the first matrix in array format
            Console.WriteLine("Enter the first matrix");
            for (a = 0; a < r; a++)
            {
                for (b = 0; b < c; b++)
                {
                    Console.Write(d[a, b] + "\t");
                }
                Console.WriteLine();
            }
            //input the value of the second matrix
            int[,] e = new int[r, c];
            Console.WriteLine("Enter the second matrix data");
            for (a = 0; a < r; a++)
            {
                for (b = 0; b < c; b++)
                {
                    e[a, b] = int.Parse(Console.ReadLine());
                }

            }
            //print out the values of the second matrix in array form
            Console.WriteLine("Enter the second matrix data");
            for (a = 0; a < r; a++)
            {
                for (b = 0; b < c; b++)
                {
                    Console.Write(e[a, b] + "\t");
                }
                Console.WriteLine();
             //result of the multiplacation of the matrix
                Console.WriteLine("Multiplication result is");
                int[,] f = new int[r, c];
                for (a = 0; a < r; a++)
                {
                    for (b = 0; b < c; b++)
                    {
                        f[a, b] = 0;
                        for (int k = 0; k < 2; k++)
                        {
                            f[a, b] += d[a, k] * e[k, b];
                        }
                    }
                }
                for (a = 0; a < r; a++)
                {
                    for (b = 0; b < c; b++)
                    {
                        Console.Write(f[a, b] + "\t");
                    }
                    Console.WriteLine("------");
                }
                Console.ReadLine();
            }
        }
    }
}

