using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class JumpGame
    {
        /*
         * 
         * You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.

            Return true if you can reach the last index, or false otherwise.

 

            Example 1:

            Input: nums = [2,3,1,1,4]
            Output: true
            Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
            Example 2:

            Input: nums = [3,2,1,0,4]
            Output: false
            Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.
 

            Constraints:

            1 <= nums.length <= 104
            0 <= nums[i] <= 105*/
        public static bool Solution(int[] nums)
        {
            int len = nums.Length;
            if (len <= 1) return true;
            for (int i = 0; i < len - 1; i++)
            {
                if (nums[i] == 0)
                {
                    int n = i - 1;  //If you can jump over the zero from any index before the zero
                    for (; n >= 0; n--)
                    {
                        if (n + nums[n] > i)
                        {
                            break;
                        }
                    }
                    if (n < 0)//else return false;
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }

                var j = nums[i] + i;
                if (j >= len - 1) return true;

                for (int k = j; k < len;)//try to jump if you can jump to the last index or more.
                {
                    if (nums[k] == 0) break;
                    if (k + nums[k] >= len - 1) return true;
                    k += nums[k];
                }

            }
            return false;
        }
    }
}
