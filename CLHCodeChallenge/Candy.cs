using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class Candy
    {
        /*
         * 
         * 
         * There are n children standing in a line. Each child is assigned a rating value given in the integer array ratings.

            You are giving candies to these children subjected to the following requirements:

            Each child must have at least one candy.
            Children with a higher rating get more candies than their neighbors.
            Return the minimum number of candies you need to have to distribute the candies to the children.

 

            Example 1:

            Input: ratings = [1,0,2]
            Output: 5
            Explanation: You can allocate to the first, second and third child with 2, 1, 2 candies respectively.
            Example 2:

            Input: ratings = [1,2,2]
            Output: 4
            Explanation: You can allocate to the first, second and third child with 1, 2, 1 candies respectively.
            The third child gets 1 candy because it satisfies the above two conditions.
 

            Constraints:

            n == ratings.length
            1 <= n <= 2 * 104
            0 <= ratings[i] <= 2 * 104*/

        public static int Solution(int[] ratings)
        {
            var ioo = new StringBuilder();
            int len = ratings.Length;
            if (len == 2)
            {
                if (ratings[0] != ratings[1])
                {
                    return 3;
                }
                return 2;
            }

            int ans = len;            
            int[] left = new int[len];
            int[] right = new int[len];

            for(int i = 1; i < len; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    left[i] = left[i - 1]+1;
                }
            }

            for(int j = len-2; j >= 0; j--)
            {
                if (ratings[j] > ratings[j + 1])
                {
                    right[j] = right[j+1]+1;
                }
            }
            for(int k = 0; k < len; k++)
            {
                ans += Math.Max(left[k], right[k]);
            }
            return ans;
        }
    }
}
