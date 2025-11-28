/*
CSE 210:
W05 Project: Mindfulness Program 
27/11/2025
- by Yain Huento

Showing Creativity and Exceeding Requirements:

    - Export a text file log of the activities choosen
     during the session

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int selection = 0;
        // define the lists for logging the activity instances
        List<BreathingActivity> breathingList = new List<BreathingActivity>();
        List<ReflectingActivity> reflectingList = new List<ReflectingActivity>();
        List<ListingActivity> listingList = new List<ListingActivity>();

        while (selection != 5)
        {

            Console.Clear();
            Console.WriteLine("Please choose one of the following:\n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Export log\n5. Quit");
            string input = Console.ReadLine();
            selection = int.Parse(input);

            if (selection == 5)
            {
                break;
            }
            else if (selection == 1)
            {
                BreathingActivity breath1 = new BreathingActivity();
                breath1.DisplayStartingMessage();
                breath1.Run();
                breathingList.Add(breath1);
            }
            else if (selection == 2)
            {
                ReflectingActivity reflect1 = new ReflectingActivity();
                reflect1.DisplayStartingMessage();
                reflect1.Run();
                reflectingList.Add(reflect1);
            }
            else if (selection == 3)
            {
                ListingActivity listing1 = new ListingActivity();
                listing1.DisplayStartingMessage();
                listing1.Run();
                listingList.Add(listing1);
            }
            else if (selection == 4) // logs activities into a text file
            {
                {
                    // get the current date and store as string
                    DateTime dateNow = DateTime.Now;
                    string dateNowString = dateNow.ToString("dd-MM-yyyy HH:mm");

                    Console.WriteLine();
                    Console.WriteLine("Please enter a name for your text file: ");
                    string fileName = Console.ReadLine();
                    using (StreamWriter outputfile = new StreamWriter($"{fileName}.txt"))
                    {
                        outputfile.WriteLine($" - MINDFULNESS PROGRAM LOG - {dateNowString} - ");
                        foreach (var x in breathingList)
                        {
                            outputfile.WriteLine();
                            outputfile.WriteLine($" -- {x.GetName()} Activity");
                            outputfile.WriteLine($" --- {x.GetDuration()} seconds");
                        }
                        foreach (var x in reflectingList)
                        {
                            outputfile.WriteLine();
                            outputfile.WriteLine($" -- {x.GetName()} Activity");
                            outputfile.WriteLine($" --- {x.GetDuration()} seconds");
                        }
                        foreach (var x in listingList)
                        {
                            List<string> list = x.GetUserList();
                            outputfile.WriteLine();
                            outputfile.WriteLine($" -- {x.GetName()} Activity");
                            foreach (var i in list)
                            {
                                outputfile.WriteLine($" ---- {i}");
                            }
                            outputfile.WriteLine($" --- {list.Count()} items listed.");
                            outputfile.WriteLine($" --- {x.GetDuration()} seconds");
                        }
                        outputfile.WriteLine();
                        outputfile.WriteLine($" - ||||||||||| ||||||| ||| - |||||||||||||||| - ");
                    }
                    Console.WriteLine($"Saved correctly to '{fileName}.txt'!");
                    Thread.Sleep(2000);
                }

            }

            else
            {
                Console.WriteLine("Invalid selection, please try again.");
                Thread.Sleep(2000);
            }
        }
    }
}
