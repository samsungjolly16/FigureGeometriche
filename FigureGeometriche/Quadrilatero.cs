using System;
using System.Collections.Generic;
using System.Text;

namespace FigureGeometriche
{
    public abstract class Quadrilatero : FigureGeometriche
    {
        public double Lato1 { get; set; }
        public double Lato2 { get; set; }
        public double Lato3 { get;set; }
        public double Lato4 { get; set; }

        public Quadrilatero(double l1, double l2, double l3, double l4) :base (4)
        {
            Lato1 = l1;
            Lato2 = l2;
            Lato3 = l3;
            Lato4 = l4;

        }
        
    }
}
