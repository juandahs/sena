using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Pentagono : IFigura
    {
        public Pentagono(int numeroLados, double loingitudLados)
        {
            NumeroLados = numeroLados;
            LongitudLados = loingitudLados;
        }        
        public int NumeroLados { get; }
        public double LongitudLados { get;  }

    }
}
