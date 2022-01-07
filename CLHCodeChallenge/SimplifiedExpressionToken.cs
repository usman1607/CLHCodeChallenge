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
            string answer;
            var exp = expression.Split(" ");
            var token = new StringBuilder();
            var result = 0;
            var count = 0;
            var pre = "-1*";
            var pre1 = "*";

            if(exp.Length == 1 && exp[0] == "0")
            {
                answer = "[]";
            }
            else
            {
                for (int i = 0; i < exp.Length; i++)
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
                        continue;
                    }
                    else if (exp[i].Equals("-"))
                    {
                        continue;
                    }
                    else if (exp[i].Equals("*"))
                    {
                        continue;
                    }
                    else
                    {
                        string str = "";
                        if (i != 0 && exp[i - 1].Equals("-"))
                        {
                            str = pre + exp[i];
                            token.Append(str);
                        }
                        else
                        {
                            str = pre1 + exp[i];
                            token.Append(str);
                        }

                    }
                }

                result += (count * ints);

                answer = $"[\"{token}\", \"{result}\"]";
            }

            return answer;
        }
    }
}
