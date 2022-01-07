using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class SimplifiedExpressionToken
    {
        public static string ExpressionToken(string expression, string vars, int ints)
        {
            expression.Replace(" ", "");

            var exp = expression.Split(" ");
            var token = new StringBuilder();
            var result = 0;
            //var lastNum = 0;
            var count = 0;

            for(int i = 0; i < exp.Length; i++)
            {
                int num = 0;
                if (exp[i].Equals(vars))
                {
                    count++;
                }
                else if (int.TryParse(exp[i], out num))
                {
                    if (i != 0 && exp[i - 1].Equals("+")) result += num;

                    if (i != 0 && exp[i - 1].Equals("-")) result -= num;

                    if (i != 0 && exp[i - 1].Equals("*")) result *= num;
                }
                else if (exp[i].Equals("+"))
                {

                }
            }

            result += (count * ints);


            return $"[\"{token}\", \"{result}\"]";
        }
    }
}
