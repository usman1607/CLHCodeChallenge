using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class LongestValidParentheses          //This will not check if the parentheses were nexted....
    {
        public static int GetLongestValid(string input)
        {
            int longestValid = 0;
            int oldLongest = 0;
            int r = 1;
            for(int i = 0; i < input.Length; i+=r)
            {
                r = 1;
                if(input[i] == '(' && input[i+1] == ')')
                {
                    longestValid += 2;
                    r = 2;
                }
                else
                {
                    if(oldLongest < longestValid)
                    {
                        oldLongest = longestValid;
                    }
                    longestValid = 0;
                }
            }
            if (oldLongest < longestValid)
            {
                oldLongest = longestValid;
            }

            return oldLongest;
        }
    }
}
