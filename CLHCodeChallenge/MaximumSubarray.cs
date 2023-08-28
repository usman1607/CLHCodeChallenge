using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class MaximumSubarray
    {
        /*
         * 
         * 
         * Given an integer array nums, find the 
            subarray
             with the largest sum, and return its sum.

 

            Example 1:

            Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
            Output: 6
            Explanation: The subarray [4,-1,2,1] has the largest sum 6.
            Example 2:

            Input: nums = [1]
            Output: 1
            Explanation: The subarray [1] has the largest sum 1.
            Example 3:

            Input: nums = [5,4,-1,7,8]
            Output: 23
            Explanation: The subarray [5,4,-1,7,8] has the largest sum 23.
 

            Constraints:

            1 <= nums.length <= 105
            -104 <= nums[i] <= 104*/
        public static int Solution(int[] nums)
        {
            var len = nums.Length;
            int max = Int32.MinValue, sum = 0;
            for (int i = 0; i < len; i++)
            {
                sum += nums[i];
                if (max < sum)
                {
                    max = sum;
                }
                //if sum at the moment is less than 0, set sum to 0.
                if (sum < 0)
                {
                    sum = 0;
                }
            }
            return max;
        }
    }
}
