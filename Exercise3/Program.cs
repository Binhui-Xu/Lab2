using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
        again:
            Console.WriteLine("Enter the first number:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENter the second number:");
            int second = Convert.ToInt32(Console.ReadLine());
            if (first > second || first < -10000 || second > 10000)
            {
                Console.WriteLine("Please enter number between -10000 and 10000");
                goto again;
            }
            Solution s = new Solution();
            int result = s.solution(first, second);
            Console.WriteLine($"The number of perfect square between this two numbers is: {result}");
        }
    }
    class Solution
    {
        public int solution(int A, int B)
        {
            int count = 0;
            for (int i = A; i <= B; i++)
            {
                for (int j = 1; j <= i / 2; j++)
                {
                    if (j*j ==i )
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
