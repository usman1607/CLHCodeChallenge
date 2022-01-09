using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class LongestPalindromeInAString
    {
        public static int LongestPalindromeLength(string str)
        {
            var result = 0;
            var containOdd = false;
            Dictionary<char, int> dic = new Dictionary<char, int>();

            //store the number of occurrence of every character in the string using a dictionary...
            for (int i = 0; i< str.Length; i++)
            {
                if (dic.ContainsKey(str[i]))
                {
                    dic[str[i]] += 1;
                }
                else
                {
                    dic.Add(str[i], 1);
                }
            }

            foreach(var value in dic.Values)
            {
                if (value % 2 == 0)
                {
                    result += value;   //Add all the values that are even numbers...
                }
                else
                {
                    result += value - 1;     
                    containOdd = true;     //If there is at least one odd number add the number - 1 and add 1 to the final result...
                }
                    
            }

            return containOdd ? result + 1 : result;
        }

        //Without dictionary...
        public static int LongestPalindromeLength2(string str)
        {
            var result = 0;
            var containOdd = false;
            var box = new StringBuilder();
            for(int i = 0; i < str.Length; i++)
            {
                int count = 0;
                if (box.ToString().IndexOf(str[i]) == -1)
                {
                    count = 1;
                    box.Append(str[i]);
                    for(int j = i + 1; j < str.Length; j++)
                    {
                        if (str[i] == str[j])
                            count++;
                    }
                }

                if (count % 2 == 0)
                {
                    result += count;  
                }
                else
                {
                    result += count - 1;
                    containOdd = true;     
                }
            }

            return containOdd ? result + 1 : result;
        }

    }
}
