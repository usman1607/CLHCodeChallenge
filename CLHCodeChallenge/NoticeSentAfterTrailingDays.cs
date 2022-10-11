using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class NoticeSentAfterTrailingDays
    {
        public static double GetMedian(int[] days)
        {
            double median = 0.0;
            Array.Sort(days);
            if(days.Length % 2 == 0)
            {
                median = (days[days.Length/2] + days[(days.Length/2) - 1]) / 2;
            }
            else
            {
                median = days[days.Length/2];
            }

            return median;
        }

        public static int NoticeSent(int[] expenditures, int d)
        {
            int notice = 0;
            if(expenditures.Length > d)
            {
                for (int i = d; i < expenditures.Length; i++)
                {
                    int start = i - d;
                    int[] days = new int[d];
                    for(int j = start, k = 0; j < i; j++,k++)
                    {
                        days[k] = expenditures[j];
                    }
                    double median = GetMedian(days);
                    if (expenditures[i] >= median * 2)
                    {
                        notice++;
                    }
                }
            }
            
            return notice;            
        }
    }
}
