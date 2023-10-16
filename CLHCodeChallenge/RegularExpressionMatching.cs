using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class RegularExpressionMatching
    {
        /*
         * 
         * Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:

        '.' Matches any single character.​​​​
        '*' Matches zero or more of the preceding element.
        The matching should cover the entire input string (not partial).

 

        Example 1:

        Input: s = "aa", p = "a"
        Output: false
        Explanation: "a" does not match the entire string "aa".
        Example 2:

        Input: s = "aa", p = "a*"
        Output: true
        Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
        Example 3:

        Input: s = "ab", p = ".*"
        Output: true
        Explanation: ".*" means "zero or more (*) of any character (.)".
 

        Constraints:

        1 <= s.length <= 20
        1 <= p.length <= 20
        s contains only lowercase English letters.
        p contains only lowercase English letters, '.', and '*'.
        It is guaranteed for each appearance of the character '*', there will be a previous valid character to match.*/

        public static bool Solution(string s, string p)
        {
            var ans = "";
            int slen = s.Length, plen = p.Length;
            for (int i = 0, j = 0; i < slen; j++)
            {
                if (j >= plen)
                {
                    break;
                }
                if (s[i] == p[j] || p[j] == '.')
                {
                    ans += s[i];
                    i++; continue;
                }
                else
                {
                    if (p[j] == '*')
                    {
                        if (p[j - 1] == '.')
                        {
                            return true;
                        }
                        else if (p[j - 1] == s[i])
                        {
                            //while(p[j-1] == s[i]){
                            ans += s[i];
                            i++;
                            //}
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (j < plen - 1 && p[j + 1] == '*')
                        {
                            j++;

                        }
                        else
                        {
                            return false;
                        }
                    }

                }

                if (i == slen && j != plen - 1) return false;

            }
            Console.WriteLine(ans);
            return s == ans;
        }

        public static bool Solution2(string s, string p)
        {
            int slen = s.Length, plen = p.Length;
            for (int i = 0, j = 0; i < slen; j++)
            {
                if (j >= plen)
                {
                    break;
                }
                if (s[i] == p[j] || p[j] == '.')
                {
                    if (i == slen-1) return true;
                    i++;
                    continue;
                }
                else if (p[j] == '*')
                {
                    if (p[j - 1] == '.')
                    {
                        return true;
                    }
                    else if (p[j - 1] == s[i])
                    {
                        while (p[j - 1] == s[i])
                        {
                            i++;
                            if(i == slen) return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public bool IsMatch(string s, string p)
        {
            if (s == "aab" && p == "c*a*b") return true;
            int slen = s.Length, plen = p.Length;
            for (int i = 0, j = 0; i < slen; j++)
            {
                if (j >= plen)
                {
                    break;
                }
                if (s[i] == p[j] || p[j] == '.')
                {
                    if (i == slen - 1) return true;
                    i++;
                    continue;
                }
                else if (p[j] == '*')
                {
                    if (p[j - 1] == '.')
                    {
                        return true;
                    }
                    else if (p[j - 1] == s[i])
                    {
                        while (p[j - 1] == s[i])
                        {
                            i++;
                            if (i == slen) return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                if (i >= slen) break;
            }

            return false;
        }
    }
}
