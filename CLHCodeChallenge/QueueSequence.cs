using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHCodeChallenge
{
    public class QueueSequence
    {
        /*
         * 
         * We are given the following sequence:
            S1 = N;
            S2 = S1 + 1;
            S3 = 2*S1 + 1;
            S4 = S1 + 2;
            S5 = S2 + 1;
            S6 = 2*S2 + 1;
            S7 = S2 + 2;
            …
            Using the Queue<T> class, write a program which by given N prints on the 
            console the first 50 elements of the sequence.
            Example: N=2  2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6,....*/

        public static string Solution(int N)
        {
            var ans = new List<int>();
            var q = new Queue<int>();
            q.Enqueue(N);
            ans.Add(N);
            for (int i = 0; i < 50; i++)
            {
                int M = q.Dequeue();
                q.Enqueue(M+1); ans.Add(M+1);
                q.Enqueue(2*M+1); ans.Add(2 * M + 1); 
                q.Enqueue(M+2); ans.Add(M+2); 
            }
            return string.Join(", ", ans);
        }
    }
}
