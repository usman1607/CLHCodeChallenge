﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CLHCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================================================");
            Console.WriteLine("=============      Welcome to CLH Code Challenge!      ==================");
            Console.WriteLine("=========================================================================");



            //Console.WriteLine(CountingValleys.countingValleys(8, "UDDDUDUU"));

            //Console.WriteLine(LongestValidParentheses2.GetLongestValid("((())())(()))(()()(()(()))(()((((()))))))((()())()))()()(()(((((()()()())))()())(()()))((((((())))((()))()()))))(()))())))()))()())((()()))))(()(((((())))))()((()(()(())((((())(())((()()(()())))())(()(())()()))())(()()()))()(((()())(((()()())))(((()()()))(()()))()))()))))))())()()((()(())(()))()((()()()((())))()(((()())(()))())())))(((()))))())))()(())))()())))())()((()))((()))()))(((())((()()()(()((()((())))((()()))())(()()(()))))())((())))(()))()))))))()(()))())(()())))))(()))((())(()((())(((((()()()(()()())))(()())()((()(()()))(()(())((()((()))))))))(()(())()())()(()(()(()))()()()(()()())))(())(()((((()()))())))(())((()(())())))))())()()))(((())))())((()(()))(()()))((())(())))))(()(()((()((()()))))))(()()()(()()()(()(())()))()))(((()(())()())(()))())))(((()))())(()((()))(()((()()()(())()(()())()(())(()(()((((())()))(((()()(((()())(()()()(())()())())(()(()()((()))))()(()))))(((())))()()))(()))((()))))()()))))((((()(())()()()((()))((()))())())(()((()()())))))))()))(((()))))))(()())))(((()))((()))())))(((()(((())))())(()))))(((()(((((((((((((())(((()))((((())())()))())((((())(((())))())(((()))))()())()(())())(()))))()))()()()))(((((())()()((()))())(()))()()(()()))(())(()()))()))))(((())))))((()()(()()()()((())((((())())))))((((((()((()((())())(()((()))(()())())())(()(())(())(()((())((())))(())())))(()()())((((()))))((()(())(()(()())))))))))((()())()()))((()(((()((()))(((((()()()()()(()(()((()(()))(()(()((()()))))()(()()((((((()((()())()))((())()()(((((()(()))))()()((()())((()())()(())((()))()()(()))"));

            //int[] input = { 2, 0, 5, 6, 4, 2, 3 };
            //Console.WriteLine(AreaOfLargestRectangle.LargestArea(input));


            //int[] input = { 7, 9, 3, 4, 5, 6 };
            //Console.WriteLine(MaximumPossibleSumOfPizzaSlice.MaximumSum(input));

            var expression = "e + 8 - a + b + 5";
            var vars = "e";
            var ints = 1;

            Console.WriteLine(SimplifiedExpressionToken.ExpressionToken(expression, vars, ints));

        }

        
    }
}
