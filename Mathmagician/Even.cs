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

        public List<int> EvenSequence(int user_number)
        { 
            //for loop that takes user input and places however many ints the user wants into a list
            List<int> EvenOutputList = new List<int>();
            int BaseNumber = 0;

            for (int i = 0; i < user_number; i++)
            {
                EvenOutputList.Add(BaseNumber);
                BaseNumber = BaseNumber + 2;
            }

            return EvenOutputList;
        }
    }
}
