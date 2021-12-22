using System;

namespace TowSum
{
    class Program
    {

        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i+1 ; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            int[] ans = new int[2];
                            ans[0] = i;
                            ans[1] = j;
                            
                            return ans;
                        }
                    }
                }
                return nums;
            }
        }
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] test = new int[3];
            test[0] = 3;
            test[1] = 2;
            test[2] = 4;

            Console.WriteLine(solution.TwoSum(test, 6));
        }
    }
}
