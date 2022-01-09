using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class MissingNumberInTheRang
    {
        public static int MissingNumber(int[] arr)
        {
            var num = 0;
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for(int x = 0; x < arr.Length; x++)
            {
                if (arr[x] != x)
                {
                    num = x;
                    break;
                }

                if (x == arr.Length - 1) num = arr.Length;
            }

            return num;
        }
    }
}
