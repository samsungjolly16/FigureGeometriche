using System;
using System.Collections.Generic;
using System.Text;

namespace FigureGeometriche
{
    public class Rombo:Quadrilatero
    {
        private double DiagonaleMagg { get; }
        private double DiagonaleMin { get; }

        public Rombo(double dMagg,double dMin, double l1, double l2, double l3, double l4) : base (l1,l2,l3,l4)
        {
            DiagonaleMagg = dMagg ;
            DiagonaleMin = dMin;
            Lato1 = l1;
            Lato2 = l2;
            Lato3 = l3;
            Lato4 = l4;
        }
        public override double CalcolaArea()
        {
            return (DiagonaleMagg * DiagonaleMin)/2;
        }
        public override double CalcolaPerimetro()
        {
            return Lato1+Lato2+Lato3+Lato4;
        }
    }
}
