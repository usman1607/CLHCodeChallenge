using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class ReverseInt
    {
        //Reverse Integer

        /*
         * 
         * 
         * Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

        Assume the environment does not allow you to store 64-bit integers (signed or unsigned).



        Example 1:

        Input: x = 123
        Output: 321
        Example 2:

        Input: x = -123
        Output: -321
        Example 3:

        Input: x = 120
        Output: 21


        Constraints:

        -231 <= x <= 231 - 1*/

        public static int Solution(int x)
        {
            var ans = 0;
            bool IsNeg = false;
            if (x < 0)
            {
                IsNeg = true;
                x = -x;
            }

            while (x > 0)
            {
                var rem = x % 10;
                ans = (ans * 10) + rem;
                x /= 10;
            }
            if (IsNeg) ans = -ans;

            ans = ans > Int32.MaxValue/2 || ans < Int32.MinValue/2 ? 0 : ans;

            return ans;
        }
    }
}
