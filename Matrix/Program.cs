using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix x = new Matrix(new int[][]
            {
                new int[]{1,2,3,4},
                new int[]{1,2,3,4},
                new int[]{1,2,3,4},
                new int[]{1,2,3,4}
            });
            Matrix y = new Matrix(new int[][]
            {
                new int[]{1,2,3,4},
                new int[]{2,3,4,5},
                new int[]{3,4,5,6},
                new int[]{4,5,6,7}
            });
            
            System.Console.WriteLine(x+"\n\n"+y);

            Matrix z = Matrix.addMatrix(x,y);

            System.Console.WriteLine(Matrix.negate(z));
        }
    }
}
