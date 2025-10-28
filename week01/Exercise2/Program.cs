using System;

class Program
{
    static void Main(string[] args)
    {
        //print text 
        Console.WriteLine("What is your Grade percentage?.");
        //get input
        string GradePercentange = Console.ReadLine();
        //convert input from string to Float
        float FloatGradePercentange = float.Parse(GradePercentange);
        //define starting letter value
        string letter = "";

        if (FloatGradePercentange >= 90)
        {
            letter = "A";
        }
        else if (FloatGradePercentange >= 80)
        {
            letter = "B";
        }
        else if (FloatGradePercentange >= 70)
        {
            letter = "C";
        }
        else if (FloatGradePercentange >= 60)
        {
            letter = "D";
        }
        else if (FloatGradePercentange < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Not valid, please try again.");
        }

        Console.WriteLine($"You got an: {letter}");

        if (FloatGradePercentange >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}


//NOTAS:
//
//AND = &&
//OR = ||
//NOT = !
/*
if (name == "Peter" || name == "James" || name == "John")
{
    Console.WriteLine("This is a biblical name.");
}


if (firstName == "Brigham" && lastName == "Young")
{
    Console.WriteLine("Welcome Brother Brigham!");
}


if (!(name == "Peter" || name == "James" || name == "John"))
{
    Console.WriteLine("This is a not one of those three");
}
*/