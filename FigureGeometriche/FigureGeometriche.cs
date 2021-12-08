

using System;
using System.Collections.Generic;
using System.Text;

namespace FigureGeometriche
{
    public abstract class FigureGeometriche
    {
        public  int nLati { get; }
        public FigureGeometriche(int numeroLati)
        {
            nLati = numeroLati;
        }
        
        public virtual double CalcolaArea()
        {
            return 0;
        }
        public virtual double CalcolaPerimetro()
        {
            return 0;
        }
    }
}
