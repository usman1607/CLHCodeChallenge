using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class WatsonSquares
    {
        public static int Solution(int a, int b)
        {
            int ans = 0;
            for(int i = a; i <= b; i++)
            {
                if(Math.Sqrt(i) % 1 == 0)
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}
