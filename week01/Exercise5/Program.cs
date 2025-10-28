using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        //define functions
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string input = Console.ReadLine();
            return input;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number:");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }

        static int SquareNumber(int userNumber)
        {
            int result = userNumber * userNumber;
            return result;
        }
        
        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"///RESULTS///");
            Console.WriteLine($"--- {userName}");
            Console.WriteLine($"--- {squaredNumber}");
        }

        //use functions
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }   
}



/*

    DisplayWelcome - Displays the message, "Welcome to the Program!"
    PromptUserName - Asks for and returns the user's name (as a string)
    PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    DisplayResult - Accepts the user's name and the squared number and displays them.

*/