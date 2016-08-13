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
            int user_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Cool. I'm going to print " + user_number + " " + command + " numbers.");
            Console.WriteLine();

            

            if (command == "odd")
            {
                OddNum my_odd = new OddNum();
                var OddNumbers = my_odd.OddSequence(user_number);

                for (var i = 0; i < OddNumbers.Count; i++)
                {
                    Console.WriteLine(OddNumbers[i]);
                }
            }
            else if (command == "even")
            {
                Even my_even = new Even();
                var EvenNumbers = my_even.EvenSequence(user_number);

                for (var i = 0; i < EvenNumbers.Count; i++)
                {
                    Console.WriteLine(EvenNumbers[i]);
                }
            }
            //else if (command == "prime")
            //{
            //    Prime my_prime = new Prime();
            //    var PrimeNumbers = my_prime.PrimeSequence(user_number);

            //    for (var i = 0; i < PrimeNumbers.Count; i++)
            //    {
            //        Console.WriteLine(PrimeNumbers[i]);
            //    }
            //}
            else if (command == "fibonacci")
            {
                Fibonacci my_fib = new Fibonacci();
                var FibNumber = my_fib.FibSequence(user_number);

                for (var i = 0; i < FibNumber.Count; i++)
                {
                    Console.WriteLine(FibNumber[i]);
                }

            } else
            {
                Console.WriteLine("Whoops!");
            }


            Console.Read();

        }

    }

}
