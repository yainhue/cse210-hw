using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your First Name?");
        string fname = Console.ReadLine();
        Console.WriteLine("What is your Last Name?");
        string lname = Console.ReadLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}


//NOTAS:
//
//Static = It means that this function doesnt belong to a class and can 
//just be run directly
//
//Void = This means what this functions is going to return,
//which is nothing!
//
//Strings[]args = ??