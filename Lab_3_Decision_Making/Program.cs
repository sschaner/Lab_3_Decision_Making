using System;

namespace Lab_3_Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lab 3: Decision Making";

            int userNumber = -1;
            string userName = "";
            bool finished = false;
            string userInput = "";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello. Welcome to Lab 3: Decision Making.\n");

            Console.ResetColor();
            // Ask for user information
            Console.Write("What is your name? ");
            userInput = Console.ReadLine();
            userName = userInput.Trim();
            Console.WriteLine($"\nWelcome {userName}. You will be asked to enter a number between 1 and 100.\nI will give you some information about your number.");

            do // Loop to continue
            {

                do // Loop if users number is not between 1 and 100
                {
                    Console.Write("\nEnter a number between 1 and 100: ");
                    userInput = Console.ReadLine();
                    userNumber = int.Parse(userInput);
                    if (userNumber <=1 || userNumber >= 100)
                    {
                        Console.WriteLine("Please enter a valid number.\n");
                    }

                    

                } while (userNumber <=1 || userNumber >= 100);

                
                
                // Check if the users number is odd or greater than 60
                if ((userNumber % 2 == 1) || userNumber > 60)
                {
                    Console.WriteLine($"{userName}, your number is {userNumber} and it's odd.\n");
                }

                // Check if users number is even
                if (userNumber % 2 == 0)
                {
                    // Check if the users number is even and in the inclusive range of 2 to 25
                    if (userNumber >= 2 && userNumber <= 25)
                    {
                        Console.WriteLine($"{userName}, your number is {userNumber}. It's even and less than 25.\n");
                    }

                    // Check if the users number is even and in the inclusive range of 26 to 60
                    if (userNumber >= 26 && userNumber <= 60)
                    {
                        Console.WriteLine($"{userName}, your number is even.\n");
                    }

                    // Check if the users number is even and greater than 60
                    if (userNumber > 60)
                    {
                        Console.WriteLine($"{userName}, your number is {userNumber} and it's even.\n");
                    }
                }

                // Ask the user if they would like to continue
                Console.Write("Continue? (y/n) ");
                userInput = Console.ReadLine();
                if (userInput.ToLower().Trim() == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nBye {userName}!");
                    Console.ResetColor();
                    finished = true;
                }


            } while (finished == false);

            Console.ReadKey();
        }
    }
}
