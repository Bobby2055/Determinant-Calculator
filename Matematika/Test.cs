using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mat;

namespace Matematika
{
    internal class Test
    {
        static void Main(string[] args)
        {
            int[,] A = new int[2, 3];
            Matrix.RandomMatrix(A);
            Matrix.PrintMatrix(A);

            int[,] B = new int[2, 3];
            Matrix.RandomMatrix(A);
            Matrix.PrintMatrix(A);
            
            Matrix.PrintMatrix(Matrix.SumMatrix(A,B));

        }
    }
}
