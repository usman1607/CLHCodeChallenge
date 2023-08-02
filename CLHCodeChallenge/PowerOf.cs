﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class PowerOf
    {
        /*
         * 
         * Implement pow(x, n), which calculates x raised to the power n (i.e., xn).
            Example 1:

            Input: x = 2.00000, n = 10
            Output: 1024.00000
            Example 2:

            Input: x = 2.10000, n = 3
            Output: 9.26100
            Example 3:

            Input: x = 2.00000, n = -2
            Output: 0.25000
            Explanation: 2-2 = 1/22 = 1/4 = 0.25
 

            Constraints:

            -100.0 < x < 100.0
            -231 <= n <= 231-1
            n is an integer.
            Either x is not zero or n > 0.
            -104 <= xn <= 104*/

        public static double Solution(double x, int n)
        {
            double ans = 1.0;
            long nn = n;
            if (nn < 0) nn = -nn;
            while (nn > 0)
            {
                if (nn % 2 == 1)
                {
                    ans = ans * x;
                    nn = nn - 1;
                }
                else
                {
                    x = x * x;
                    nn = nn / 2;
                }
            }
            if (n < 0) ans = (double)(1.0) / (double)(ans);
            return ans;
        }

        public static double Solution2(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n < 0)
            {
                n = -n;
                x = 1 / x;
            }
            double ans = x;
            for (int i = 1; i < n; i++)
            {
                ans *= x;
            }
            return ans;
        }
    }
}
