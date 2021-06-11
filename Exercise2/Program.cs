using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            again1:
            Console.WriteLine("Enter array size:");
            int size = Convert.ToInt32(Console.ReadLine());
            if (size < 1 || size > 1000)
            {
                Console.WriteLine("Please enter a size between 1 and 1000.");
                goto again1;
            }
            again2:
            Console.WriteLine("Enter array values:");
            string inputNums = Console.ReadLine();
            int[] array = Array.ConvertAll(inputNums.Split(" "), int.Parse);
            foreach (int item in array)
            {
                if (item < 0 || item > 10000)
                {
                    Console.WriteLine("Please enter the value between 0 and 10000.");
                    goto again2;
                }
            }
            Solution s = new Solution();
            int result = s.solution(array);
            Console.WriteLine($"The number occurs most often in this array is: {result}");
        }
    }
    class Solution
    {
        public int solution(int[] A)
        {
            int count = 0;
            int candidate = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (count == 0)
                {
                    candidate = A[i];
                    count++;
                }
                else if (candidate == A[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return candidate;
        }
    }
}
