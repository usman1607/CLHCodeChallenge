using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class InreaseLastDigit
    {
        public static int[] NewArrayOfDigits(int[] arr)
        {
            StringBuilder str = new StringBuilder();
            foreach (int digit in arr)
            {
                str.Append(digit.ToString());
            }
            var digits = (long.Parse(str.ToString()) + 1).ToString();

            var result = new int[digits.Length];
            int i = 0;
            foreach (char digit in digits)
            {
                result[i] = int.Parse(digit.ToString());
                i++;
            }

            return result;
        }
    }
}
