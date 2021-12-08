using System;
using System.Collections.Generic;
using System.Text;

namespace FigureGeometriche
{
    public class Triangolo:FigureGeometriche
    {
        public  double Lato1 { get; private set; }
        public  double Lato2 { get; }
        public double Lato3 { get; }
        public Triangolo(double lato1,double lato2, double lato3) : base(3)
        {
            Lato1 = lato1;
            Lato2 = lato2;
            Lato3 = lato3;
        }
        public override double CalcolaPerimetro()
        {
            return Lato1+Lato1+Lato3;
        }
        public override double CalcolaArea()
        {
            double p = CalcolaPerimetro();
            return Math.Sqrt((p / 2) * ((p / 2) - Lato1) * ((p / 2) - Lato2) * ((p / 2) - Lato3));
        }
    }
}
