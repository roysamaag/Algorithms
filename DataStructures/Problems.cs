using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Problems
    {
        long[] f = null;

        public long Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            if (f[n] == -1)
                f[n] = (Fibonacci(n - 1) + Fibonacci(n - 2));


            return f[n];
        }


        public long Fibonacci_c(int n)
        {
            f = new long[n + 1];

            f[0] = 0;
            f[1] = 1;

            for (long i = 2; i <= n; i++)
                f[i] = -1;


            return (Fibonacci(n));
        }




    }
}
