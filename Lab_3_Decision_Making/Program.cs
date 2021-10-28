using System;

namespace Lab_3_Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool finished = false;
            string userInput = "";

            Title();
            WelcomeMessage();
            string userName = GetUserName();
            IntroductionMessage(userName);

            do // Loop to continue
            {
                int userNumber = -1;
                do // Loop if users number is not between 1 and 100
                {
                    userNumber = GetUserNumber();
                    InvalidNumber(userNumber);
                } while (userNumber <= 1 || userNumber >= 100);

                string evenMessage = MessageIfEven(userNumber, userName);
                string oddMessage = OddMessage(userNumber, userName);

                if (evenMessage != "")
                {
                    Console.WriteLine(evenMessage);
                }

                if (oddMessage != "")
                {
                    Console.WriteLine(oddMessage);
                }

                finished = WouldUserLikeToContinue(userInput, userName, finished);

            } while (finished == false);

            Console.ReadKey();
        }

        // shows the title of the application
        public static void Title()
        {
            Console.Title = "Lab 3: Decision Making";
        }

        // Welcomes the user
        public static void WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello. Welcome to Lab 3: Decision Making.\n");
            Console.ResetColor();
        }

        // Gets the users name
        public static string GetUserName()
        {
            // Ask for users name
            Console.Write("What is your name? ");
            string userInput = Console.ReadLine();
            return userInput.Trim();
        }

        // Displays an introduction message that tells the user what the application will do
        public static void IntroductionMessage(string userName)
        {
            Console.WriteLine($"\nWelcome {userName}. You will be asked to enter a number between 1 and 100.\nI will give you some information about your number.");
        }

        // Get users number
        public static int GetUserNumber()
        {
            Console.Write("\nEnter a number between 1 and 100: ");
            string userInput = Console.ReadLine();
            return int.Parse(userInput);
        }

        // Output message if user number is invalid
        public static void InvalidNumber (int userNumber)
        {
            if (userNumber <= 1 || userNumber >= 100)
            {
                Console.WriteLine("Please enter a valid number.\n");
            }
        }

        // Output message if users number is odd
        public static string OddMessage (int userNumber, string userName)
        {
            string outputMessage = "";
            // Check if the users number is odd
            if (userNumber % 2 == 1)
            {
                outputMessage = $"{userName}, your number is {userNumber} and it's odd.\n";
                return outputMessage;
            }
            else
            {
                return outputMessage;
            }
        }

        // Returns a message, depending on different tests of being even
        public static string MessageIfEven(int userNumber, string userName)
        {
            string outputMessage = "";
            // Check if users number is even
            if (userNumber % 2 == 0)
            {
                // Check if the users number is even and in the inclusive range of 2 to 25
                if (userNumber >= 2 && userNumber <= 25)
                {
                    outputMessage = $"{userName}, your number is {userNumber}. It's even and less than 25.\n";
                    return outputMessage;
                }
                // Check if the users number is even and in the inclusive range of 26 to 60
                else if (userNumber >= 26 && userNumber <= 60)
                {
                    outputMessage = $"{userName}, your number is even.\n";
                    return outputMessage;
                }
                // Check if the users number is even and greater than 60
                else if (userNumber > 60)
                {
                    outputMessage = $"{userName}, your number is {userNumber} and it's even.\n";
                    return outputMessage;
                }
                else
                {
                    return outputMessage;
                }
            }
            else
            {
                return outputMessage;
            }
        }

        public static bool WouldUserLikeToContinue(string userInput, string userName, bool finished)
        {
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
            return finished;
        }
    }
}
