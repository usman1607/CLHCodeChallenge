using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class LongestValidParentheses2
    {
        public static int GetLongestValid(string input)
        {
            int longestValid = 0;

            //Get all possible substring and compare  the length of all the valid substring ..
            for (int i = 0; i < input.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(input.Length - i);
                for (int j = i; j < input.Length; ++j)
                {
                    subString.Append(input[j]);
                    if (IsValid(subString.ToString()))
                    {
                        if (longestValid < subString.Length)
                        {
                            longestValid = subString.Length;
                        }
                    }
                }
            }
            return longestValid;
        }

        private static bool IsValid(string subString)
        {
            int count = 0;
            for (int i = 0; i < subString.Length; i++)
            {
                if (subString[i] == '(')
                {
                    count++;
                }
                else if (subString[i] == ')')
                {
                    count--;
                }
                if (count < 0)
                {
                    return false;
                }
            }
            return count == 0 ? true : false;
        }

    }
}
