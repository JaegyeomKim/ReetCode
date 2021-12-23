using System;

namespace PalindromeNumber
{

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            int a = 121;
            int b1 = a / 100;
            int b2 = a % 100 / 10;
            int b3 = a % 10;
            Math.Ceiling(Math.Log10(a));

            int c = 1234;
            int c1 = c / 1000;
            int c2 = c % 1000 / 100;
            int c3 = c % 100 /10;
            int c4 = c % 10; 
            int marh = (int)Math.Ceiling(Math.Log10(c));

            int digit = 1;
            for (int i = 0; i < marh; i++)
            {
                digit *= 10;
            }
            int check = digit;
            for (int i = 0; i < marh; i++)
            {
                //if (digit == check)
                //{
                //    c / digit
                //}
            }

            Math.Ceiling(Math.Log10(a));
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            return true;
        }
    }


    public class Solution2
    {
        public bool IsPalindrome2(int x)
        {
            if (x < 0)
            {
                return false;
            }
            int test = (int)Math.Log10(x);
            string y = x.ToString();


            for (int i = 0; i < test; i++)
            {

                if (y[i] == y[test])
                {
                    test -= 1;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution2 solution2 = new Solution2();
            Console.WriteLine(solution2.IsPalindrome2(121));
            Console.WriteLine(solution2.IsPalindrome2(10));
            Console.WriteLine(solution2.IsPalindrome2(-121));

        }
    }
}
