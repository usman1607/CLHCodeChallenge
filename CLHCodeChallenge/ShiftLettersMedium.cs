using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class ShiftLettersMedium
    {
        public static string Solution(string s, int[] shifts)
        {
            var str = new StringBuilder(s);
            for(int i = 0; i < shifts.Length; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    for(int k = 0; k < shifts[i]; k++)
                    {
                        str[j] = Shift(str[j]);
                    }
                }
            }
            return str.ToString();
        }

        static char Shift(char c)
        {
           return c == 'z' ? 'a' : (char)(c + 1);
        }
    }
}
