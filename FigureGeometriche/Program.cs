using System;

namespace FigureGeometriche
{
    class Program
    {
        static void Main(string[] args)
        {
            Rombo rb = new Rombo(25, 20,10,10,10,10);
            Console.WriteLine(rb.CalcolaArea());
            Console.WriteLine(rb.CalcolaPerimetro());
            Rettangolo r = new Rettangolo(10, 12);
            Console.WriteLine(r.CalcolaArea());
            Console.WriteLine(r.CalcolaPerimetro());
            Triangolo t = new Triangolo(10, 10, 10);
            Console.WriteLine(t.CalcolaArea());
            Console.WriteLine(t.CalcolaPerimetro());
            int a = t.nLati;
            int b = rb.nLati;
            Console.WriteLine(a +" "+b);

        }
    }
}
