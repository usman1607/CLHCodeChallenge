using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    // Longest Common Prefix
    public class LongestCommonPrefix
    {
        /*
         * 
         * Write a function to find the longest common prefix string amongst an array of strings.

            If there is no common prefix, return an empty string "".

 

            Example 1:

            Input: strs = ["flower","flow","flight"]
            Output: "fl"
            Example 2:

            Input: strs = ["dog","racecar","car"]
            Output: ""
            Explanation: There is no common prefix among the input strings.
 

            Constraints:

            1 <= strs.length <= 200
            0 <= strs[i].length <= 200
            strs[i] consists of only lowercase English letters.*/

        public static string Solution(string[] strs)
        {
            var sorted = new PriorityQueue<string, int>();
            foreach (var s in strs)
            {
                sorted.Enqueue(s, s.Length);
            }
            for(int k = 0; k < strs.Length; k++)
            {
                strs[k] = sorted.Dequeue();
            }
            //Array.Sort(strs);
            var ans = ""; bool stop = false;
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 0; j < strs.Length - 1; j++)
                {
                    if (strs[j][i] != strs[j + 1][i])
                    {
                        stop = true;
                        break;
                    }
                }
                if (!stop)
                {
                    ans += strs[0][i];
                }
                else
                {
                    break;
                }

            }
            return ans;
        }
    }
}
