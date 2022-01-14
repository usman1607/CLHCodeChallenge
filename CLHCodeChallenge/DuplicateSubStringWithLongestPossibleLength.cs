using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class DuplicateSubStringWithLongestPossibleLength
    {
        public static string LongestDuplicatedSubstring(string input)
        {
            var result = "";
            string temp, temp2;
            for (int i = 0; i < input.Length/2; ++i)
            {
                for (int j = i; j < input.Length; ++j)
                {
                    temp = input.Substring(i, j-i+1);

                    for(int k = j; k < input.Length; k++)
                    {
                        for (int l = k; l < input.Length; l++)
                        {
                            temp2 = input.Substring(k, l - k + 1);
                            if (temp == temp2 && result.Length < temp.Length)
                            {
                                if ( (temp.Length == 1) && (i == input.IndexOf(input[i])) )
                                {
                                    continue;
                                }
                                result = temp;
                            }
                            if (temp.Length < temp2.Length) break;
                        }
                    }

                }
            }
            
            return result;
        }
    }
}
