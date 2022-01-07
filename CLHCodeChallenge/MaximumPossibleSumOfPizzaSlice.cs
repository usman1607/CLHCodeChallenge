using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class MaximumPossibleSumOfPizzaSlice
    {
        public static int MaximumSum(int[] input)
        {
            var maxSum = 0;
            var sum1 = input[1] + input[input.Length - 1];
            var sum2 = input[0] + input[input.Length - 2];

            for (int i = 0; i < input.Length - 2; i++)
            {
                var sum = input[i] + input[i + 2];
                if(maxSum < sum)
                {
                    maxSum = sum;
                }
            }

            if(maxSum < sum2) maxSum = sum2;

            if (maxSum < sum1) maxSum = sum1;

            return maxSum;
        }
    }
}
