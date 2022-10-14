using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class IllegaalCar
    {
        public static int Solution(string s)
        {
            int units = 0;
            var str = new StringBuilder(s);
            while(s.IndexOf('1') != -1)
            {
                if (str[0] == '1')
                {
                    str.Remove(0, 1);
                    units++;
                }
                else if (str[s.Length - 1] == '1')
                {
                    str.Remove(str.Length-1, 1);
                    units++;
                }
                else
                {
                    str.Remove(s.IndexOf('1'), 1);
                    units += 2;
                }
                s = str.ToString();
            }

            return units;
        }
    }
}
