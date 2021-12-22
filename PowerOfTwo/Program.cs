using System;

namespace PoweOfTow
{

    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n == 1)
            {
                return true;
            }

            int num = 1;
            for (int i = 0; i < n; i++) // 4
            {
                num *= 2;
                if (num == n)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsPowerOfTwo(1)); //t
            Console.WriteLine(solution.IsPowerOfTwo(2));
            Console.WriteLine(solution.IsPowerOfTwo(6));
            Console.WriteLine(solution.IsPowerOfTwo(8));



        }
    }
}
