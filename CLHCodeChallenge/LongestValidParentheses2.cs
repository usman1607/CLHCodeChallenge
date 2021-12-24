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

            //Get all possible substring..
            List<string> allSubStrings = new List<string>();
            for (int i = 0; i < input.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(input.Length - i);
                for (int j = i; j < input.Length; ++j)
                {
                    subString.Append(input[j]);
                    allSubStrings.Add(subString.ToString());
                }
            }

            //Compare the length of all the valid substrings...
            foreach(var str in allSubStrings)
            {
                if(IsValid(str))
                {
                    if(longestValid < str.Length)
                    {
                        longestValid = str.Length;
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
