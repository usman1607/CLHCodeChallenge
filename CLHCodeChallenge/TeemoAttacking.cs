using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class TeemoAttacking
    {
        public static int Solution(int[] times, int d)
        {            
            var seconds = new HashSet<int>();
            for(int i = 0; i < times.Length; i++)
            {
                for(int j = 0; j < d; j++)
                {
                    seconds.Add(times[i]);
                    times[i]++;
                }
            }
            return seconds.Count;
        }
    }
}
