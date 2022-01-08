using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class DuplicateZeroOccurrence
    {
        // The method should be void because the question says you should not return anything...
        public static void DuplicateZeros(int[] arr)
        {
            int[] myArr = new int[arr.Length];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if(arr[i] != 0)
                {
                    myArr[j] = arr[i];
                    j++;
                }
                else if (arr[i] == 0 && i < arr.Length - 1)
                {
                    myArr[j] = arr[i];
                    j += 2;
                }

                if (j >= arr.Length) break;
            }
            for(int i = 0; i < arr.Length; i++) arr[i] = myArr[i];
        }
        
        //If you don't want to create another array...
        public static void DuplicateZeros2(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0 && i < arr.Length - 1)
                {
                    //duplicate the zero and shift to the back...
                    for(int j = arr.Length-1; j > i+1; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    arr[i + 1] = 0;
                    i++;
                }
            }
        }

        public static void DuplicateZeros3(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == 0)
                {
                    //re-assign to the array from the back while removing the last element and duplicate the zero...
                    for (int j = arr.Length - 1; j > i; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                }
            }
        }
    }
}
