using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class AreaOfLargestRectangle
    {

        public static int LargestArea(int[] input)
        {
            int LargestArea = 0;

            for(int i = 0; i < input.Length; i++)
            {
                int count = 1;
                for(int x = 1; x < input.Length - i; x++)
                {
                    if(input[i + x] < input[i])
                    {
                        break;
                    }
                    count++;
                }

                for(int y = 0; y < i; y++)
                {
                    if (input[i - y - 1] < input[i])
                    {
                        break;
                    }
                    count++;
                }
                int area = count * input[i];
                if(LargestArea < area)
                {
                    LargestArea = area;
                }

            }

            return LargestArea;
        }
    }
}
