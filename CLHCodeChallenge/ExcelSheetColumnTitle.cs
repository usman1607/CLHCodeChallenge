using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class ExcelSheetColumnTitle
    {
        /*
         * 
         * Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.

            For example:

            A -> 1
            B -> 2
            C -> 3
            ...
            Z -> 26
            AA -> 27
            AB -> 28 
            ...
 

            Example 1:

            Input: columnNumber = 1
            Output: "A"
            Example 2:

            Input: columnNumber = 28
            Output: "AB"
            Example 3:

            Input: columnNumber = 701
            Output: "ZY"
 

            Constraints:

            1 <= columnNumber <= 231 - 1*/

        public static string Solution(int columnNumber)
        {
            var letters = new string[]{"Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y"};
            string ans = "";
            while (columnNumber > 0)
            {
                var rem = columnNumber % 26;
                ans += letters[rem];
                if (rem > 0)
                {
                    columnNumber /= 26;
                }
                else
                {
                    columnNumber = (columnNumber / 26) - 1;
                }
            }
            var x = ans.ToCharArray();
            Array.Reverse(x);
            return new string(x);
        }
    }
}
