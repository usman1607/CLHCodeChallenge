using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class RepeatedSubstringPattern
    {
        /*
         * 
         * 
         * Given a string s, check if it can be constructed by taking a substring of it and appending multiple copies of the substring together.

            Example 1:

            Input: s = "abab"
            Output: true
            Explanation: It is the substring "ab" twice.
            Example 2:

            Input: s = "aba"
            Output: false
            Example 3:

            Input: s = "abcabcabcabc"
            Output: true
            Explanation: It is the substring "abc" four times or the substring "abcabc" twice.
 
            Constraints:

            1 <= s.length <= 104
            s consists of lowercase English letters.*/

        public static bool Solution(string s)
        {
            for (int i = 1; i <= s.Length / 2; i++)
            {
                var ss = s.Substring(0, i);
                for (int j = i; j <= s.Length - i; j += i)
                {
                    if (ss != s.Substring(j, i))
                    {
                        break;
                    }
                    else
                    {
                        if (i + j == s.Length) return true;
                        continue;
                    }
                }
            }
            return false;
        }
    }
}
