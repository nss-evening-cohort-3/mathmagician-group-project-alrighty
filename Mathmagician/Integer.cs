using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        public int FirstNumber()
        {
            return 1;
        }

        public int FollowingNumber(int v)
        {
            return 4;
        }

        public List<int> IntegerSequence(int user_number)
        {
            //for loop that takes user input and places however many ints the user wants into a list
            List<int> IntOutputList = new List<int>();
            for (int i = 0; i <= user_number; i++)
            {
                IntOutputList.Add(i);
            }

            return IntOutputList;

        }
    }
}
                                                                                                                                                                                                                                      