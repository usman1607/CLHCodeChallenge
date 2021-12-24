using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    class CountingValleys
    {
        public static int countingValleys(int steps, string path)
        {
            int result = 0;
            int hill = 0;
            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    hill++;

                }
                else if (path[i] == 'D')
                {
                    hill--;
                }
                if (hill == 0 && path[i] == 'U')
                {
                    result++;
                }
            }
            return result;
        }
    }
}
