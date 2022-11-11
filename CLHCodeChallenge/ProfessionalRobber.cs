using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class ProfessionalRobber
    {
        public static int Solution(int[] nums)
        {
            int money1 = 0, money2 = 0;
            for(int i = 0; i < nums.Length; i+=2)
            {
                money1 += nums[i];
                if(i+1 < nums.Length)
                {
                    money2 += nums[i+1];
                }
            }
            return money1 > money2 ? money1 : money2;
        }
    }
}
