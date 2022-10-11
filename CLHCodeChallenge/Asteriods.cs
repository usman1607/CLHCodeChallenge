using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class Asteriods
    {
        public static string Solution(int[] arr)
        {
            var ans = new List<int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    for(int j = i+1; j < arr.Length; j++)
                    {
                        if (arr[j] < 0)
                        {
                            if (arr[i] == Math.Abs(arr[j]))
                            {
                                arr[i] = 0; arr[j] = 0; break;
                            }
                            else if (arr[i] > Math.Abs(arr[j]))
                            {
                                arr[j] = 0;
                            }
                            else
                            {
                                arr[i] = 0; break;
                            }
                        }
                        else if (arr[j] > 0)
                        {
                            break;
                        }
                        
                    }
                }
                else if(arr[i] < 0)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (arr[j] > 0)
                        {
                            if (Math.Abs(arr[i]) == arr[j])
                            {
                                arr[i] = 0; arr[j] = 0; break;
                            }
                            else if (Math.Abs(arr[i]) > arr[j])
                            {
                                arr[j] = 0;
                            }
                            else
                            {
                                arr[i] = 0; break;
                            }
                        }
                        else if (arr[j] < 0)
                        {
                            break;
                        }

                    }
                }
            }

            foreach (var item in arr)
            {
                if(item != 0)
                {
                    ans.Add(item);
                }
            }

            return $"[{string.Join(",", ans)}]";
        }
    }
}
