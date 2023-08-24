using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class LongestConsecutiveSequence
    {
        //Longest Consecutive Sequence
        /*
         * 
         * Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

        You must write an algorithm that runs in O(n) time.



        Example 1:

        Input: nums = [100,4,200,1,3,2]
        Output: 4
        Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
        Example 2:

        Input: nums = [0,3,7,2,5,8,4,6,0,1]
        Output: 9


        Constraints:

        0 <= nums.length <= 105
        -109 <= nums[i] <= 109*/

        public static int Solution(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int ans = 1, max = 1;
            var sort = new PriorityQueue<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                sort.Enqueue(nums[i], nums[i]);
            }
            var temp = sort.Dequeue();
            for (int j = 1; j < nums.Length; j++)
            {
                var next = sort.Dequeue();
                if (next - temp == 1)
                {
                    ans++;
                }
                else if (next == temp)
                {
                    continue;
                }
                else
                {
                    ans = 1;
                }
                if (ans > max)
                {
                    max = ans;
                }
                temp = next;
            }
            return max;
        }
    }
}
