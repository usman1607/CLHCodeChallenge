using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class FallSquares
    {
        public static int[] Solution(int[,] arr)
        {
            int max = arr[0, 1];
            var ans = new int[arr.GetLength(0)];
            var cumHs = new Dictionary<int, int>();
            
            for(int i = 0; i < arr.GetLength(0); i++)
            {                
                int h = arr[i,1];
                for (int j = i -1; j >= 0; j--)
                {
                    if (arr[j, 0] < arr[i, 0] && arr[j, 0] + arr[j, 1] > arr[i, 0])
                    {
                        int k = cumHs.ContainsKey(j) ? cumHs[j] : arr[j, 1];
                        h = k + arr[i, 1];
                        if(cumHs.TryGetValue(i, out int l))
                        {
                            cumHs[i] = l > h ? l : h;
                        }
                        else
                        {
                            cumHs.Add(i, h);
                        }                        
                    }
                    if(h > max)
                    {
                        max = h;
                    }
                }
                ans[i] = max;

            }
            return ans;
        }

    }
}
