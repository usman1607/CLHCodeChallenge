using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class ThreeSum
    {

        /*
         * 
         * 
         * Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
            Notice that the solution set must not contain duplicate triplets.

            Example 1:

            Input: nums = [-1,0,1,2,-1,-4]
            Output: [[-1,-1,2],[-1,0,1]]
            Explanation: 
            nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
            nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
            nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
            The distinct triplets are [-1,0,1] and [-1,-1,2].
            Notice that the order of the output and the order of the triplets does not matter.
            Example 2:

            Input: nums = [0,1,1]
            Output: []
            Explanation: The only possible triplet does not sum up to 0.
            Example 3:

            Input: nums = [0,0,0]
            Output: [[0,0,0]]
            Explanation: The only possible triplet sums up to 0.
 

            Constraints:

            3 <= nums.length <= 3000
            -105 <= nums[i] <= 105*/


        public static List<List<int>> Solution(int[] nums)
        {
            var myNums = new PriorityQueue<int, int>();
            var ans = new List<List<int>>();
            for (int x = 0; x < nums.Length; x++)
            {
                myNums.Enqueue(nums[x], nums[x]);
            }
            for (int y = 0; y < nums.Length; y++)
            {
                nums[y] = myNums.Dequeue();
            }
           
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            var l = new List<int>() { nums[i], nums[j], nums[k] };
                            if (!ans.Any(x => x[0] == l[0] && x[1] == l[1] && x[2] == l[2])) ans.Add(l);
                        }
                        
                    }
                }
            }
            return ans;
        }

        //More efficent solution...
        public static List<int[]> Solution2(int[] nums)
        {
            Array.Sort(nums);
            var len = nums.Length;
            List<int[]> ans = new List<int[]>();
            int low, high, sum;
            for (int i = 0; i < len - 2; i++)
            {
                low = i + 1; high = len - 1;
                while (low < high)
                {
                    sum = nums[i] + nums[low] + nums[high];
                    if (sum == 0)
                    {
                        if (!ans.Any(x => x[0] == nums[i] && x[1] == nums[low] && x[2] == nums[high]))
                        {
                            ans.Add(new int[3] { nums[i], nums[low], nums[high] });
                        }
                        low++;
                    }
                    else if (sum < 0)
                    {
                        low++;
                    }
                    else
                    {
                        high--;
                    }
                }
            }
            return ans;
        }
    }

    
}
