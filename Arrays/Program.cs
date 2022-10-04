using System;

namespace arrays
{
    class arrays
    {
        public static void Main(String[] args)
        {
            int i, j, row,col;
            int[,] matA = new int[10, 10];
            int[,] matB = new int[10, 10];
            int[,] res  = new int[10, 10];
            Console.WriteLine("Enter the size of the matrix Row: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the size of the matrix column: ");
            col = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements to the  matrix A: ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write("matA : ["+i+","+j+"] : ");
                    matA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the elements to the  matrix B: ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write("matB : [" + i + "," + j + "] : ");
                    matB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("matrix A elements :");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(matA[i, j]+" ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("matrix B elements :");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(matB[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Addition of the two Matrices Result : ");
            for(i = 0; i < row; i++)
            {
                for(j= 0; j < col; j++)
                {
                    res[i, j] = matA[i, j] + matB[i, j];
                }
            }
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(res[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}