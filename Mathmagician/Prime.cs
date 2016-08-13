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

        public static bool isPrime(int number)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(number));
            if (number == 1)
                return false;
            if (number == 2)
                return false;
            for (int i = 2; i <= boundary; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public List<int> PrimeSequence(int user_number)
        {
            return new List<int> { 2, 3, 5, 7, 11, 13 };

            //for loop that takes user input and places however many ints the user wants into a list
            List<int> PrimeOutputList = new List<int>();
            for (int i == 2; i <= user_number; i++)
            {

            }
        }
    }
}
