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

        public List<int> PrimeSequence(int user_number)
        {


            //for loop that takes user input and places however many ints the user wants into a list
            List<int> PrimeOutputList = new List<int>();
            PrimeOutputList.Add(2);
            int followingPrime = 3;

            // THE FOLLOWING ONLY TESTS ODD NUMBERS 
            while (PrimeOutputList.Count < user_number)
            {
                int sqrt = (int)Math.Sqrt(followingPrime);
                bool isPrime = true;
                for (int i = 0; (int)PrimeOutputList[i] <= sqrt; i++)
                {
                    if (followingPrime % PrimeOutputList[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    PrimeOutputList.Add(followingPrime);
                }
                followingPrime += 2;
            }
            return PrimeOutputList;
        }
    }
}
