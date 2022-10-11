using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class ElementToTheLeftAndRight
    {
        public static string BothAreEqual(int[] arr)
        {
            for(int i = 1; i < arr.Length-1; i++)
            {
                int rightSum = 0, leftSum = 0;
                for(int j = i-1; j >= 0; j--)
                {
                    leftSum += arr[j];
                }

                for(int j = i+1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }

                if(rightSum == leftSum)
                {
                    return "Yes";
                }
            }

            return "No";
        }
    }
}
