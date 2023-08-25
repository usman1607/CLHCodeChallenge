﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class ContainerWithMostWater
    {
        /*
         * 
         * https://leetcode.com/problems/container-with-most-water/description/
         * You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

            Find two lines that together with the x-axis form a container, such that the container contains the most water.

            Return the maximum amount of water a container can store.

            Notice that you may not slant the container.

 

            Example 1:


            Input: height = [1,8,6,2,5,4,8,3,7]
            Output: 49
            Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.
            Example 2:

            Input: height = [1,1]
            Output: 1
 

            Constraints:

            n == height.length
            2 <= n <= 105
            0 <= height[i] <= 104*/
        public static int Solution(int[] height)
        {
            int temp, end = height.Length - 1, start = 0, max = 0;
            while (start < end)
            {
                temp = height[start] < height[end] ? height[start] * (end - start) : height[end] * (end - start);
                if (max < temp)
                {
                    max = temp;
                }
                if (height[start] < height[end])
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            return max;

        }
    }
}
