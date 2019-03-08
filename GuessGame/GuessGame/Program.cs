using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    class Program
    {
        const int MaxLives = 10;

        const string answer = "666";

        static void Main(string[] args)
        {
            int Lives = MaxLives;

            Console.WriteLine("Hello World");
            Console.WriteLine("Welcome to 'GUESS GAME'!");
            Console.WriteLine("The Rules are simple. Guess the creater's number.");
            Console.WriteLine("Oh and you only have 10 Trials.");
            Console.WriteLine("Tip: its between 0 and 1000. Good luck");
            while (Lives > 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Please Enter a number or quit.");
                string input = Console.ReadLine();

                if (input == answer)
                {
                    Console.WriteLine("Gratz!!! You guessed the number!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Lives = Lives - 1;
                    Console.WriteLine(" ");
                    Console.WriteLine("Sorry Love, That was wrong.");
                    Console.WriteLine("You have " + Lives + " lives left");
                    Console.WriteLine("Go Hit another number :D");

                }
            }
            if ( Lives == 0)
            {
                Console.WriteLine("You are out of lives :( Goodbye");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}