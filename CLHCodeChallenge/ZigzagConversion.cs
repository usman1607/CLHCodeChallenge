using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class ZigzagConversion
    {
        /*
         * 
         * 
         * The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

            P   A   H   N
            A P L S I I G
            Y   I   R
            And then read line by line: "PAHNAPLSIIGYIR"

            Write the code that will take a string and make this conversion given a number of rows:

            string convert(string s, int numRows);
 

            Example 1:

            Input: s = "PAYPALISHIRING", numRows = 3
            Output: "PAHNAPLSIIGYIR"
            Example 2:

            Input: s = "PAYPALISHIRING", numRows = 4
            Output: "PINALSIGYAHRPI"
            Explanation:
            P     I    N
            A   L S  I G
            Y A   H R
            P     I
            Example 3:

            Input: s = "A", numRows = 1
            Output: "A"
 

            Constraints:

            1 <= s.length <= 1000
            s consists of English letters (lower-case and upper-case), ',' and '.'.
            1 <= numRows <= 1000*/

        public static string Solution(string s, int numRows)
        {
            if (s.Length < numRows || numRows < 2) return s;
            var str = new StringBuilder();
            var arr = new List<List<char>>();
            for (int i = 0; i < numRows; i++)
            {
                if (i < s.Length)
                {
                    var f = new List<char>() { s[i] };
                    arr.Add(f);
                }
            }

            var n = numRows - 1;
            for (int i = numRows; i < s.Length;)
            {
                if (i % n == 0)
                {
                    for (int j = 0; j < numRows; j++)
                    {
                        if (i < s.Length)
                        {
                            arr[j].Add(s[i]);
                            i++;
                        }
                    }
                }
                else
                {
                    for (int j = n - 1; j > 0; j--)
                    {
                        if (i < s.Length)
                        {
                            arr[j].Add(s[i]);
                            i++;
                        }
                    }
                }
            }
            for (int k = 0; k < numRows; k++)
            {
                str.Append(arr[k].ToArray());
            }

            return str.ToString();
        }
    }
}
