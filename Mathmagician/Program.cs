using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like for me to do?");
            String command = Console.ReadLine().ToLower();
            Console.WriteLine("How many should I print?");
            String user_number = Console.ReadLine();
            Console.WriteLine("Cool. I'm going to print " + user_number + " " + command + " numbers.");
            Console.ReadKey();
        }
    }
}
