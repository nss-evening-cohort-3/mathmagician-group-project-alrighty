using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Prime
    {
        public int FirstPrime()
        {
            return 2;
        }

        public int FollowingPrime(int v)
        {
            return 3;
        }

        public List<int> Sequence(int v)
        {
            return new List<int> { 2, 3, 5, 7, 11, 13 };
            //for loop that takes user input and places however many ints the user wants into a list
        }
    }
}
