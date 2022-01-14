using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class RemoveTheMinimumNumberOfInvalidParentheses
    {
        public static string AllPossibleResult(string input)
        {
            Console.WriteLine(input);
            var str = input.ToCharArray();
            List<string> results = new List<string>(); 
            List<string> myResults = new List<string>();
            List<char> temp = new List<char>();
            for(int i = 0; i < str.Length; i++)
            {
                str[i] = ' ';

                if (IsValid(str))
                {
                    results.Add(string.Join("", str));
                }
                str[i] = input[i];
            }
            for(int i = 0; i < results.Count; i++)
            {
                var myStr = results[i].Split(' ');
                var myResult = string.Join("", myStr.ToArray());
                myResults.Add(myResult)
            }
          
            var result = string.Join(",", myResults.ToArray());

            return $"[\"{result}\"]";
        }

        private static bool IsValid(char[] subString)
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
