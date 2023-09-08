using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class ReorganizeString
    {
        /*
         * 
         * Given a string s, rearrange the characters of s so that any two adjacent characters are not the same.

            Return any possible rearrangement of s or return "" if not possible.

 

            Example 1:

            Input: s = "aab"
            Output: "aba"
            Example 2:

            Input: s = "aaab"
            Output: ""
 

            Constraints:

            1 <= s.length <= 500
            s consists of lowercase English letters.
        
         Approch explained.
        ====================
         Count the frequency of each character in the given string using an Dictionary, and then using a priority queue to store the characters in descending order of their frequency. The priority queue is used to ensure that the most frequent characters are chosen first for the reorganized string.
          The reorganization process involves selecting the most frequent character and then selecting the next most frequent character that is different from the previously selected character. This process is repeated until all characters have been used or until it is not possible to select a different character. Finally, the resulting string is checked to ensure that no adjacent characters are the same, and the reorganized string is returned.
         
         */

        public static string Solution(string s)
        {
            var len = s.Length;
            if(len <= 1) return s;

            var ans = new StringBuilder();
            var dic = new Dictionary<char, int>();
            // (Comparer<int>.Create((x, y) => y - x)) is used to overide the ascending behaviour and use descending instead.
            var queue = new PriorityQueue<char, int>(Comparer<int>.Create((x, y) => y - x));
            for (int i = 0; i < len; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]]++;
                }
                else
                {
                    dic.Add(s[i], 1);
                }
            }
            foreach(var pair in dic)
            {
                queue.Enqueue(pair.Key, pair.Value);
            }

            while(queue.TryDequeue(out char key, out int value) && value > 0) 
            {                
                ans.Append(key);
                value--;
                var sec = queue.TryDequeue(out char key2, out int value2);
                if(value2 > 0)
                {
                    ans.Append(key2);
                    value2--;
                }

                if(value > 0)
                {
                    queue.Enqueue(key, value);
                }
                if(value2 > 0)
                {
                    queue.Enqueue(key2, value2);
                }

                if(ans.Length > 1 && ans[ans.Length-1] == ans[ans.Length-2])
                {
                    return "";
                }
            }

            return ans.ToString();
        }

    }
}
