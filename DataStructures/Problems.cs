using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Problems
    {
        public long Fibonacci_Recusrive(int n)
        {
            if (n <= 1) return n;

            long tt = (Fibonacci_Recusrive(n - 1) + Fibonacci_Recusrive(n - 2));
            
            Console.WriteLine(n);
            return tt;

        }

        public int[] Fibonacci_Dynamic(int n)
        {
            int[] arr = new int[n + 1];

            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr;

        }

        public int Fibonacci_nonRecursive(int n)
        {
            int a = 0;
            int b = 1;
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }

    }
}
