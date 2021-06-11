using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = {{ 1,2,3},
                        {4,5,6 },
                        { 7,8,9}};
            spirlOrder(a);
        }
        public static void spirlOrder(int[ , ] matrix)
        {
            int col = matrix.GetLength(0);
            int row = matrix.GetLength(1);
            int i, k=0, l = 0;
            while (k < row && l < col)
            {
                for (i = l; i < col; ++i)
                {
                    Console.Write(matrix[k, i] + " ");
                }
                k++;
                for (i = k; i < row; ++i)
                {
                    Console.Write(matrix[i, col - 1] + " ");
                }
                col--;
                if (k < row)
                {
                    for (i = col - 1; i >= l; --i)
                    {
                        Console.Write(matrix[row-1,i]+" ");
                    }
                    row--;
                }
                if (l < col)
                {
                    for (i = row - 1; i >= k; --i)
                    {
                        Console.Write(matrix[i,l]+" ");
                    }
                    l++;
                }
            }
        }

    }
}
