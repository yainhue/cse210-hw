using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> lista = new List<Shape>();
        Square sq = new Square("rojo", 5);
        Rectangle re = new Rectangle("amarillo", 3, 2);
        Circle ci = new Circle("violeta", 10);

        lista.Add(sq);
        lista.Add(re);
        lista.Add(ci);

        foreach (var s in lista)
        {
            Console.WriteLine();
            Console.WriteLine(s);
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}