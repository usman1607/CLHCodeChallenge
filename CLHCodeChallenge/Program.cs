using System;
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

            string path = "UDDDUDUU";
            int steps = 8;

            //Console.WriteLine(CountingValleys.countingValleys(steps, path));

            Console.WriteLine(LongestValidParentheses.GetLongestValid("(())(((()()))"));

            
        }

        
    }
}
