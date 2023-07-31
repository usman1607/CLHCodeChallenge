using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        /*
         * 
         * Given a string s, find the length of the longest 
            substring
             without repeating characters.

 

            Example 1:

            Input: s = "abcabcbb"
            Output: 3
            Explanation: The answer is "abc", with the length of 3.
            Example 2:

            Input: s = "bbbbb"
            Output: 1
            Explanation: The answer is "b", with the length of 1.
            Example 3:

            Input: s = "pwwkew"
            Output: 3
            Explanation: The answer is "wke", with the length of 3.
            Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 

            Constraints:

            0 <= s.length <= 5 * 104
            s consists of English letters, digits, symbols and spaces.*/

        public static int Solution(string s)
        {
            if (s.Length == 1) return 1;
            int ans = 0, start = 0, count = 1;
            for (int i = 1; i < s.Length; i++)
            {
                while ((s.Substring(start, i - start)).Contains(s[i]))
                {
                    start++; count--;
                    if (start == i)
                    {
                        continue;
                    }

                }

                count++;
                if (ans < count)
                {
                    ans = count;
                }

            }
            return ans;
        }
    }
}
