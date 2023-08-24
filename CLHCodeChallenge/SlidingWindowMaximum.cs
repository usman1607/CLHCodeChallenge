using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class SlidingWindowMaximum
    {
        /*
         * 
         * You are given an array of integers nums, there is a sliding window of size k which is moving from the very left of the array to the very right. You can only see the k numbers in the window. Each time the sliding window moves right by one position.

            Return the max sliding window.

 

            Example 1:

            Input: nums = [1,3,-1,-3,5,3,6,7], k = 3
            Output: [3,3,5,5,6,7]
            Explanation: 
            Window position                Max
            ---------------               -----
            [1  3  -1] -3  5  3  6  7       3
             1 [3  -1  -3] 5  3  6  7       3
             1  3 [-1  -3  5] 3  6  7       5
             1  3  -1 [-3  5  3] 6  7       5
             1  3  -1  -3 [5  3  6] 7       6
             1  3  -1  -3  5 [3  6  7]      7
            Example 2:

            Input: nums = [1], k = 1
            Output: [1]
 

            Constraints:

            1 <= nums.length <= 105
            -104 <= nums[i] <= 104
            1 <= k <= nums.length*/

        public static int[] Solution(int[] nums, int k)
        {
            var ans = new int[nums.Length - k + 1];
            var max = nums[0];
            for (int i = 0; i < nums.Length - k + 1; i++)
            {
                if (i != 0 && Array.IndexOf(nums, max, i, k) >= i)
                {
                    if (max < nums[i + k - 1])
                    {
                        max = nums[i + k - 1];
                    }
                }
                else
                {
                    max = nums[i];
                    for (int j = i + 1; j < i + k; j++)
                    {
                        if (max < nums[j])
                        {
                            max = nums[j];
                        }
                    }
                }
                ans[i] = max;
            }
            return ans;
        }
    }
}
