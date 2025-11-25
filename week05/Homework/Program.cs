using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("TAREA 1:");
        MathAssigment tarea1 = new MathAssigment("rodrigo", "algebra", "math 101", "p. 135-200");
        Console.WriteLine(tarea1.GetSummary());
        Console.WriteLine(tarea1.GetHomeworkList());
        Console.WriteLine("TAREA 2:");
        WrittingAssigment tarea2 = new WrittingAssigment("alberta", "historia mundial", "que paso master? - la guerra de mroeno");
        Console.WriteLine(tarea2.GetWritingInformation());
    }
}