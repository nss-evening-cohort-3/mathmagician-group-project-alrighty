using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mathmagician
{
    public class OddNum
    {
        public List<int> OddSequence(int user_number)
        {
            List<int> OddOutputList = new List<int>();
            int BaseNumber = 1;

            for (int i = 0; i < user_number; i++)
            {
                OddOutputList.Add(BaseNumber);
                BaseNumber = BaseNumber + 2;
            }
            return OddOutputList;
        }
    }
}