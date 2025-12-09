/*
CSE 210:
W06 Project
09/12/2025
- by Yain Huento

Showing Creativity and Exceeding Requirements:

    - Keep track of the times an EternalGoal is recorded
    - With the help of Console.Clear and Console.ReadLine make the menus cleaner and easier to read.
    - Enabled CSV to work well with commas

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Console.WriteLine();
        List<Goal> goalList = new List<Goal>();
        GoalManager gm1 = new GoalManager(goalList, 0);
        gm1.Start();
    }
}