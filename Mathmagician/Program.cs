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

            string prompt = "> ";

            Console.WriteLine("What number pattern would you like for me to use?");
            Console.WriteLine();
            Console.WriteLine("Integer  |   Prime   |   Fibonacci   |   Even    |   Odd");
            Console.WriteLine();
            Console.Write(prompt);
            string command = Console.ReadLine().ToLower();
            Console.WriteLine();
            Console.WriteLine("How many should I print?");
            Console.WriteLine();
            int user_number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Cool. I'm going to print " + user_number + " " + command + " numbers.");
            Console.WriteLine();

            if (command == "odd")
            {
                for (var i = 1; i < user_number * 2; i++)
                {
                    Console.Write(i++ + " ");
                }
            } else if (command == "even")
            {
                for (var i = 2; i < user_number * 2; i++)
                {
                    Console.Write(i++ + " ");
                }
            } else if (command == "prime")
            {
                for (var i = 1; i < user_number; i++)
                {
                    Console.Write(i + " ");
                }
            }

            

            Console.ReadKey();



        }

    }
}
