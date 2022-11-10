using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class ToggleBulbs
    {
        public static int Solution(int n)
        {
            if(n == 0 || n == 1)
            {
                return n;
            }

            int count = 0;
            int[] bulbs = new int[n];

            for(int i = 0; i < n; i++)
            {
                if(i == n - 1)
                {
                    bulbs[i] = bulbs[i] == 0 ? 1 : 0;
                    break;
                }
                for(int j = i; j < n; j+=i+1)
                {
                    if(i == 0)
                    {
                        bulbs[j] = 1;
                    }
                    else if(i == 1)
                    {
                        bulbs[j] = 0;
                    }
                    else
                    {
                        bulbs[j] = bulbs[j] == 0 ? 1 : 0;
                    }
                }
            }
            for(int k = 0; k < n; k++)
            {
                if(bulbs[k] == 1)
                    count++;
            }

            return count;
        }
    }
}
