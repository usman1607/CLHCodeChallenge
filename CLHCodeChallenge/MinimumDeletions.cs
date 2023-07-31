using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    //Minimum Deletions to Make Character Frequencies Unique
    public class MinimumDeletions
    {
        /*
         * 
         * A string s is called good if there are no two different characters in s that have the same frequency.

        Given a string s, return the minimum number of characters you need to delete to make s good.

        The frequency of a character in a string is the number of times it appears in the string. For example, in the string "aab", the frequency of 'a' is 2, while the frequency of 'b' is 1.

        Example 1:
        Input: s = "aab"
        Output: 0
        Explanation: s is already good.

        Example 2:
        Input: s = "aaabbbcc"
        Output: 2
        Explanation: You can delete two 'b's resulting in the good string "aaabcc".
        Another way it to delete one 'b' and one 'c' resulting in the good string "aaabbc".

        Example 3:
        Input: s = "ceabaacb"
        Output: 2
        Explanation: You can delete both 'c's resulting in the good string "eabaab".
        Note that we only care about characters that are still in the string at the end (i.e. frequency of 0 is ignored).
 
        Constraints:
        1 <= s.length <= 105
        s contains only lowercase English letters.*/

        public static int Solution(string s)
        {
            int ans = 0;
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]] += 1;
                }
                else
                {
                    dic.Add(s[i], 1);
                }
            }

            //var list = new List<int>(dic.Values);
            var set = new List<int>();
            foreach(var value in dic.Values)
            {
                if (!set.Contains(value))
                {
                    set.Add(value);
                }
                else
                {
                    var temp = value;
                    while(temp > 0 && set.Contains(temp))
                    {
                        temp--;
                        ans++;
                    }
                    set.Add(temp);                    
                }
            }
            return ans;
        }
    }
}
