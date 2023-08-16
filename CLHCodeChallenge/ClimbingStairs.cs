using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class ClimbingStairs
    {
        /*
         * 
         * 
         * You are climbing a staircase. It takes n steps to reach the top.

            Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

 

            Example 1:

            Input: n = 2
            Output: 2
            Explanation: There are two ways to climb to the top.
            1. 1 step + 1 step
            2. 2 steps
            Example 2:

            Input: n = 3
            Output: 3
            Explanation: There are three ways to climb to the top.
            1. 1 step + 1 step + 1 step
            2. 1 step + 2 steps
            3. 2 steps + 1 step
 

            Constraints:

            1 <= n <= 45*/
        public static int Solution(int n)
        {
            //keep the last two result for last two numbers of stairs...
            int ans = 1, t = 0, p = 1;
            for (int i = 0; i < n; i++)
            {
                //Add previous two to get current.. e.g. (n = 3) result = (n = 1)'s result plus (n =2)'s result...
                //So for 1 which is when i = 0, the previous resuts will be 1 and 0 to give us 1...
                ans = t + p;
                t = p; p = ans;
            }
            return ans;
        }
    }
}
