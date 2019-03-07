using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Welcome to 'GUESS GAME'!");
            Console.WriteLine("The Rules are simple. Guess the creater's number.");
            Console.WriteLine("Oh and you only have 10 Trials.");
            Console.WriteLine("Tip: its between 0 and 1000. Good luck");
            while (true)
            {
                Console.WriteLine("Please Enter a number or quit.");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "666":
                        Console.WriteLine("Gratz!!! You guessed the number!");
                        break;
                    case "quit":
                        Console.WriteLine("Bye");
                        return;
                    default:
                        Console.WriteLine("Hehe wrong number ;)");
                        break;
                }
            }
        }
    }
}
