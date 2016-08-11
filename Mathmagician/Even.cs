using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Even
    {
        public int FirstEven()
        {
            return 2;
        }

        public int FollowingEven(int v)
        {
            return 4;
        }

        public List<int> EvenSequence(int v)
        {
            return new List<int> { 2, 4, 6, 8, 10, 12 };
            //for loop that takes user input and places however many ints the user wants into a list
           

        }
    }
}
