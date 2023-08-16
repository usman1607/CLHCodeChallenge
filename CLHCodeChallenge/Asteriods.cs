using CLHCodeChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*We are given an array asteroids of integers representing asteroids in a row.
For each asteroid, the absolute value represents its size, and the sign represents its direction (positive meaning right negative meaning left). Each asteroid moves at the same speed.
Find out the state of the asteroids after all collisions. If two asteroids meet, the smaller one will explode. If both are the same size, both will explode. Two asteroids moving in the same direction will never meet.
Example 1:
Input: asteroids = [5, 10, -5] Output: (5, 10] Explanation: The 10 and - 5 collide resulting in 10. The 5 and 10 never collide.
Example 2:
Input: asteroids = [8, -8] Output: [] Explanation: The 8 and - 8 collide exploding each other.
Example 3:
Input: asteroids = [10, 2, -5] Output: [10] Explanation: The 2 and - 5 collide resulting in -5. The 10 and -5 collide resulting in 10.*/

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
