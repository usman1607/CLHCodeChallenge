using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class ProfessionalRobberCircle
    {
        public static int Solution(int[] nums)
        {
            int money1 = 0, money2 = 0;
            int len = nums.Length % 2 == 0 ? nums.Length : nums.Length - 1;
            for(int i = 0; i < len; i += 2)
            {
                money1 += nums[i];
                money2 += nums[i + 1];                
            }
            if(nums.Length % 2 != 0 && nums[0] < nums[len])
            {
                money1 += nums[len] -= nums[0];
            }

            return money1 > money2 ? money1 : money2;
        }
    }
}
