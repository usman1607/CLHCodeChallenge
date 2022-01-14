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
            var str = input.ToList();
            List<string> results = new List<string>();
            for(int i = 0; i < str.Count; i++)
            {
                Console.WriteLine(str.ToString());
                str.Remove(str[i]);
                Console.WriteLine(str.ToString());

                if (IsValid(str))
                {
                    results.Add(str.ToString());
                }
            }

            var result = string.Join(",", results.ToArray());

            return $"[\"{result}\"]";
        }

        private static bool IsValid(List<char> subString)
        {
            int count = 0;
            for (int i = 0; i < subString.Count; i++)
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
