using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise1
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userInput;

            do
            {

                Console.WriteLine("Guess a number between 1 & 1000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is to low.");

                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high.");
                }
                else
                {
                    Console.WriteLine($"You guessed it!");
                }
            } while (favNumber != userInput);

            //Exercise 2

            Console.WriteLine("What is your favorite subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine($"I hate math!");
                    break;
                case "science:":
                case "biology":
                    Console.WriteLine($"Science is really nice, I love it.");
                    break;
                case "phys ed":
                    Console.WriteLine($"Physical Education is my favorite subject");
                    break;
                case "history":
                    Console.WriteLine($"History is boring.");
                    break;
                case "english":
                    Console.WriteLine($"English is really fun.");
                    break;
                default:
                    Console.WriteLine("I don't know that subject");
                    break;

            }
        }
    }
}
