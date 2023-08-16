using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class WordBreak
    {
        /*
         * 
         * Given a string s and a dictionary of strings wordDict, return true if s can be segmented into a space-separated sequence of one or more dictionary words.

            Note that the same word in the dictionary may be reused multiple times in the segmentation.

 

            Example 1:

            Input: s = "leetcode", wordDict = ["leet","code"]
            Output: true
            Explanation: Return true because "leetcode" can be segmented as "leet code".
            Example 2:

            Input: s = "applepenapple", wordDict = ["apple","pen"]
            Output: true
            Explanation: Return true because "applepenapple" can be segmented as "apple pen apple".
            Note that you are allowed to reuse a dictionary word.
            Example 3:

            Input: s = "catsandog", wordDict = ["cats","dog","sand","and","cat"]
            Output: false
 

            Constraints:

            1 <= s.length <= 300
            1 <= wordDict.length <= 1000
            1 <= wordDict[i].length <= 20
            s and wordDict[i] consist of only lowercase English letters.
            All the strings of wordDict are unique.*/

        public static bool Solution(string s, IList<string> wordDict)
        {
            /*int j; 
            for(int i = 0; i < s.Length; i+=j)
            {
                j = 1;                
                while (!wordDict.Contains(s.Substring(i, j)))
                {
                    j++;
                    if(j+i > s.Length) return false;
                }

                if (wordDict.Contains(s.Substring(i + j)))
                {
                    return true;
                }
            }

            return true;*/

            /*if(s.Length == 0) return true;
            for(int i = 1; i <= s.Length; i++)
            {
                if(wordDict.Contains(s.Substring(0,i)) && Solution(s.Substring(i, s.Length - i), wordDict))
                {
                    return true;
                }
            }

            return false;*/

            string[] arr = new string[s.Length + 1];
            return Check(s, wordDict, 0, new bool[s.Length]);
        }

        public static bool Check1(string s, IList<string> wordDict, string[] arr)
        {
            if (s.Length == 0) return true;
            for (int i = 1; i <= s.Length; i++)
            {
                if (wordDict.Contains(s.Substring(0, i)))
                {
                    if (arr.Contains(s.Substring(0, i)))
                    {
                        if (i == s.Length)
                        {
                            return true;
                        }
                        continue;
                    }

                    arr[s.Length] = s.Substring(0, i);
                    if (Check1(s.Substring(i, s.Length - i), wordDict, arr))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool Check(string s, IList<string> wordDict, int start, bool[] arr)
        {
            if (s.Length == 0) return true;

            if (arr[start] != false)
            {
                return arr[start];
            }

            for (int end = start + 1; end <= s.Length; end++)
            {
                // If substring is found in the `worddict`, 
                // recursively call the function
                // for the remaining portion
                // of the string
                if (wordDict.Contains(s.Substring(start, end)) && Check(s, wordDict, end, arr))
                {
                    return arr[start] = true;
                }
            }
            return arr[start] = false;
        }

        public static bool Check2(string s, IList<string> wordDict, string[] arr)
        {
            if (s.Length == 0) return true;
            for (int i = 1; i <= s.Length; i++)
            {
                if (wordDict.Contains(s.Substring(0, i)))
                {

                    if (arr.Contains(s.Substring(0, i)))
                    {
                        if (i == s.Length)
                        {
                            return true;
                        }
                        if (wordDict.Contains(s.Substring(i)))
                        {
                            return true;
                        }
                        continue;
                    }

                    arr[s.Length] = s.Substring(0, i);
                    if (Check2(s.Substring(i, s.Length - i), wordDict, arr))
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        public static bool wordBreak(String s, IList<String> wordDict)
        {
            HashSet<String> word_dictionary_set = new HashSet<string>(wordDict);

            bool[] dp = new bool[s.Length + 1];

            dp[0] = true;
            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {

                    if (dp[j] && word_dictionary_set.Contains(s.Substring(j, i)))
                    {

                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[s.Length];
        }



        //Java that passed all the test cases
        /*public boolean wordBreak(String s, List<String> wordDict)
        {
            Set<String> word_dictionary_set = new HashSet<>(wordDict);

            boolean[] dp = new boolean[s.length() + 1];

            dp[0] = true;
            for (int i = 1; i <= s.length(); i++)
            {
                for (int j = 0; j < i; j++)
                {

                    if (dp[j] && word_dictionary_set.contains(s.substring(j, i)))
                    {

                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[s.length()];
        }*/

    }
}
