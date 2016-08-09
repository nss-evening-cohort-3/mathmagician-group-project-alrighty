using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class FibonacciNum
    {

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
        public int FirstNumber()
        {
           return 1;
        }

        public int FollowingNumber(int v)
        {
            return 8;
        }

        public List<int> Sequence(int v)
        {
           return new List<int> { 1, 1, 3, 5, 8, 13 };
        }
    }
}
