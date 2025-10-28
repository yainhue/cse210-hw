using System;
using System.Formats.Asn1;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.WriteLine("Enter number");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        //calculate total sum
        int total = 0;
        foreach (int i in numbers)
        {
            total += i;
        }
        Console.WriteLine($"The sum is {total}");

        //calculate average
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        //calculate largest number
        int largest = numbers.Max();
        Console.WriteLine($"The largest number is {largest}");
    }
}