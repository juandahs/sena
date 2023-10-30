using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AreaPoligonoRegular
{
    internal class Poligono : IFigura
    {
        public Poligono(int numeroLados, double longitudLados)
        {
            NumeroLados = numeroLados;
            LongitudLados = longitudLados;
        }

        public int NumeroLados { get; }
        public double LongitudLados { get; }
    }
}
