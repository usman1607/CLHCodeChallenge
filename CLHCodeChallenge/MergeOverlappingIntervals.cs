using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class MergeOverlappingIntervals
    {
        public static int[][] Solution(int[,] intervals)
        {
            
            var result = new List<int[]>();
            var overlapped = new List<int>();
            var len = intervals.GetLength(0);
            for (int i = 0; i < len; i++)
            {
                if (overlapped.Contains(i))
                {
                    continue;
                }
                var arr1 = new int[] { intervals[i,0], intervals[i,1] };
                for (int j = i + 1; j < len; j++)
                {
                    if (overlapped.Contains(j))
                    {
                        continue;
                    }
                    var arr2 = new int[] { intervals[j, 0], intervals[j, 1] };
                    if (Overlap(arr1, arr2))
                    {
                        overlapped.Add(j);
                    }
                }
                result.Add(arr1);
            }

            return result.ToArray();
        }

        private static bool Overlap(int[] arr1, int[] arr2)
        {
            if ((arr1[0] <= arr2[0] && arr2[0] <= arr1[1]) || (arr2[0] <= arr1[0] && arr1[0] <= arr2[1]))
            {
                arr1[0] = arr1[0] < arr2[0] ? arr1[0] : arr2[0];
                arr1[1] = arr1[1] > arr2[1] ? arr1[1] : arr2[1];

                return true;
            }
            return false;
        }
    }
}
