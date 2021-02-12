using System;

namespace FindMyNumber
{
    class Program
    {
        static void Main()
        {
            //Variables
            int min;
            int max;
            int guess = 0;
            int number = 0;
            int atempts;
            string input;
            //Tests for loop
            bool minTest;
            bool maxTest;
            bool guessTest;
            //Setting random
            Random picker = new Random();
            //Welcome message
            Console.WriteLine("Welcome in guessing game!");
            Console.WriteLine("In this game you have to guess number that machine will pick");
            //Ask about range
            Console.WriteLine("Give me range for random numbers (only int value)");
            //Take and test if min is a number
            do
            {
                Console.Write("Min: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out min))
                {
                    //If yes, convert to int and save as min
                    min = Convert.ToInt32(input);
                    minTest = true;
                }
                else
                {
                    Console.WriteLine("First number isn't a digit!\nType it again!");
                    input = Console.ReadLine();
                    minTest = false;
                }
            } while (minTest == false);
            //Take and test if max is number
            do
            {
                Console.Write("Max: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out max))
                {
                    //If yes, convert to int and save as max
                    max = Convert.ToInt32(input);
                    maxTest = true;
                }
                else
                {
                    Console.WriteLine("Second number isn't a digit!\nType it again!");
                    input = Console.ReadLine();
                    maxTest = false;
                }
            } while (maxTest == false);
            //Message
            number = picker.Next(min, max);
            Console.WriteLine($"Generating number...\nDone! Guess my number from {min} to {max}");
            for (atempts = 1; guess != number; atempts++)
            {
                do
                {
                    Console.Write("Guess: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out guess))
                    {
                        //If yes, convert to int and save as max
                        guess = Convert.ToInt32(input);
                        guessTest = true;
                    }
                    else
                    {
                        Console.WriteLine("Guess number isn't a digit!\nType it again!");
                        input = Console.ReadLine();
                        guessTest = false;
                    }
                } while (guessTest == false);
                if (guess > number)
                {
                    Console.WriteLine("My number is smaller than yours!");
                }
                else if (guess < number)
                {
                    Console.WriteLine("My number is greater than yours!");
                }
                else if (guess == number)
                {
                    Console.WriteLine($"Well done! You guess my number in {atempts} atempts!");
                }
            }
            Console.Read();
        }
    }
}
