﻿using System;

//Namespace
namespace NumberGuesser
{
    //Main class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo function to get info

            GreetUser(); // Ask for user input

            while(true)
            { 

                    //Init correct number
                    //int correctNumber = 7;

                    //Create a new Random object

                    Random random = new Random();

                    int correctNumber = random.Next(1, 11);

                    // Init guess var
                    int guess = 0;

                    //Ask user for number
                    Console.WriteLine("Guess a number between 1 and 10.");

                    //While guess is not correct
                    while(guess != correctNumber)
                    {
                        //Get users input
                        string input = Console.ReadLine();

                        //Make sure its a number
                        if (!int.TryParse(input, out guess))
                        {
                        //Print error messgae
                            PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                            //Keep going
                            continue;

                        }

                        //Cast to int and put in guess
                        guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Set color
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");

                    }
                    

                }

                ////Print success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!!! You guessed it!");

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();
                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }


        }

        //Get and display app info.
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Derek Cobb";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

        }
        //Ask user's name and greet

        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game. . .", inputName);

        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user it is not a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();

        }
    }
}
