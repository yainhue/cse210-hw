/*
CSE 210:
W02 Project: Journal Program
05/11/2025
- Written by Yain Huento

Showing Creativity and Exceeding Requirements:

    - Added a check in the main menu for out of range selections
    - Improve the process of saving and loading to save as a .csv file that could be opened in
      Excel (works best with LibreOffice)

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int selection = 0;
        Journal journal = new Journal();


        while (selection != 5)
        {
            Console.WriteLine("Please choose one of the following:\n1. Write\n2. Display\n3. Save\n4. Load\n5. Quit\nWhat would you like to do?");
            string input = Console.ReadLine();
            selection = int.Parse(input);

            if (selection == 5)
            {
                break;
            }   
            else if (selection == 1)
            {
                journal.AddEntry(journal);
            }
            else if (selection == 2)
            {
                journal.DisplayAll();
            }
            else if (selection == 3)
            {
                journal.SaveToFile(journal);
            }
            else if (selection == 4)
            {
                journal.LoadFromFile(journal);
            }
            else
            {
                Console.WriteLine("Incorrect selection, please try again.");
                Console.WriteLine();
            }
        }
    }
}