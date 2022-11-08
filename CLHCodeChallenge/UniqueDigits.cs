using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class UniqueDigits
    {
        public static int Solution(int n)
        {
            int count = 0;
            int num = (int)Math.Pow(10, n);
            for(int i = 0; i < num; i++)
            {
                if (HasUniqueDigits(i.ToString()))
                {
                    count++;
                }
            }
            return count;

        }

        private static bool HasUniqueDigits(string x)
        {
            if(x.Length == 1)
                return true;

            int len = x.Length % 2 == 0 ? x.Length/2 : x.Length/2 + 1;
            for(int i = 0; i < len; i++)
            {
                if (x.LastIndexOf(x[i]) != i)
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}
