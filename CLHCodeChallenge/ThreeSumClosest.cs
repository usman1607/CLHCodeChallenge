using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class ThreeSumClosest
    {
        /*
         * 
         * Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.

            Return the sum of the three integers.

            You may assume that each input would have exactly one solution.

 

            Example 1:

            Input: nums = [-1,2,1,-4], target = 1
            Output: 2
            Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
            Example 2:

            Input: nums = [0,0,0], target = 1
            Output: 0
            Explanation: The sum that is closest to the target is 0. (0 + 0 + 0 = 0).
 

            Constraints:

            3 <= nums.length <= 500
            -1000 <= nums[i] <= 1000
            -104 <= target <= 104*/

        public static int Solution(int[] nums, int target)
        {
            Array.Sort(nums);
            var ans = nums[0] + nums[1] + nums[2];
            int temp = ans, len = nums.Length;
            /*for (int i = 1; i < len - 2; i++)
            {
                int sum = nums[i] + nums[i + 1] + nums[i + 2];
                if (sum == temp)
                {
                    continue;
                }
                if (Math.Abs(sum - target) < Math.Abs(ans - target))
                {
                    ans = sum;
                }
                temp = sum;
            }*/

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int sum = nums[i] + nums[j] + nums[k];
                        if (sum == target) return sum;
                        if (sum == temp)
                        {
                            continue;
                        }
                        if (Math.Abs(sum - target) < Math.Abs(ans - target))
                        {
                            ans = sum;
                        }
                        temp = sum;

                    }
                }
            }
            return ans;
        }
    }
}
