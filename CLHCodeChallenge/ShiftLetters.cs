using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class ShiftLetters
    {
        public static string Solution(string s, int[,] shifts)
        {
            var str = new StringBuilder(s);
            for(int i = 0; i < shifts.GetLength(0); i++)
            {
                if (shifts[i,2] == 1)
                {
                    for(int j = shifts[i,0]; j <= shifts[i,1]; j++)
                    {
                        str[j] = str[j] == 'z' ? 'a' : (char)(str[j] + 1);
                    }
                }
                else if(shifts[i,2] == 0)
                {
                    for (int j = shifts[i,0]; j <= shifts[i,1]; j++)
                    {
                        str[j] = str[j] == 'a' ? 'z' : (char)(str[j] - 1);
                    }
                }
            }
            return str.ToString();
        }
    }
}
