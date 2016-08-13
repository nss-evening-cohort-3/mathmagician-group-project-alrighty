using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Fibonacci
    {
        public List<int> FibSequence(int user_number)
        {
            List<int> FibOutputList = new List<int>();
            int a = 0;
            int b = 1;

            for (int i = 0; i < user_number; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;

                FibOutputList.Add(b);
            }
            return FibOutputList;
        }

        public int FirstNumber()
        {
            return 0;
        }

        public int FollowingNumber(int v)
        {
            return 1;
        }
    }
}


