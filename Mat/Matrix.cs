using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mat
{
    public class Matrix
    {
        public static void RandomMatrix(int[,] A)
        {
            Random rnd = new Random();
            for(int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(0); j++)
                {
                    A[i, j] = rnd.Next(1, 999);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
        public static void PrintMatrix(int[,] A)
        {
            int[,] Rezult = new int[A.GetLength(0), A.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("{0,5}", A[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static int[,] SumMatrix(int[,] A, int[,] B)
        {
            if (A.GetLength(0) == B.GetLength(0) || (A.GetLength(1) == B.GetLength(1)))
            {
                int[,] Rezult = new int[A.GetLength(0), A.GetLength(1)];
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(0); j++)
                    {
                        Rezult[i, j] = A[i, j] + B[i, j];
                    }
                }
                return Rezult;
            }
            else
            {
                throw new Exception("Ne moje da se izvarsi deistvieto ");
            }
        }
    }
}
