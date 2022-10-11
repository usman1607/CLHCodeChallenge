using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class CounterGame
    {
        public static string Winner(int number)
        {
            string winner = "";
            if(number == 1)
            {
                winner = "Richard";
            }
            else
            {
                int count = 0;
                while (number > 1)
                {
                    if (IsPowerOfTwo(number))
                    {
                        number /= 2;
                        count++;
                    }
                    else
                    {
                        number -= NextLowerPowerOfTwo(number);
                        count++;
                    }

                    if (number == 1)
                    {
                        winner = count % 2 != 0 ? "Louise" : "Richard";
                    }
                }
            }
            return winner;
        }
        public static bool IsPowerOfTwo(int number)
        {
            while(number > 1)
            {
                if(number % 2 != 0)
                {
                    return false;
                }
                number /= 2;
            }
            return true;
        }

        public static int NextLowerPowerOfTwo(int number)
        {
            int result = 1;
            while(result < number)
            {
                result *= 2;
            }
            return result / 2;
        }
    }
}
