using System;
using System.Collections.Generic;
using System.Text;

namespace FigureGeometriche
{
    public class Rettangolo:Quadrilatero
        
    {
        private double Base { get; }
        private double Altezza { get; }
        public Rettangolo(double b, double a): base(b,a,b,a)
        {
            Base = b;
            Altezza = a;

        }
        public override double CalcolaArea()
        {
            return Base * Altezza / 2;
        }
        public override double CalcolaPerimetro()
        {
            return (Base + Altezza) * 2;
        }

    }
}
