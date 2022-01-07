using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class MaximalRectangle
    {
        public static int AreaOfMaximumRec(int[,] input)
        {
            int max = 0;
            int row = input.GetLength(0) - 1;
            int col = input.GetLength(1) - 1;

            //Get all matrixes
            List<int[,]> mtxs = new List<int[,]>();
            for(int i = row; i >= 0; i--)
            {
                for (int j = col; j >= 0; j--)
                {
                    int[,] mtx = new int[i, j];
                    mtxs.Add(mtx);
                }
                          
            }

            //Assign value and chech the area...

            for (int i = row; i >= 0; i--)
            {
                for (int j = col; j >= 0; j--)
                {
                    int[,] mtx = new int[i, j];
                    
                }

            }
            return max;
        }

        private static int sum(int[,] mtx)
        {
            int sum = 0;
            for(int i = 0; i < mtx.GetLength(0); i++)
            {
                for(int j = 0; j < mtx.GetLength(1); j++)
                {
                    sum += mtx[i, j];
                }
            }
            return sum;
        }
    }
}
