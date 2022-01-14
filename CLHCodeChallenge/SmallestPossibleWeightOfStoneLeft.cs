using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class SmallestPossibleWeightOfStoneLeft
    {
        public static int WeightOfStoneLeft(int[] arr)
        {
            if (arr.Length == 1) return arr[0];

            return 2;
        }
    }
}
