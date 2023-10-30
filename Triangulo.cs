using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Triangulo : IFigura
    {
        public Triangulo( int numeroLados, double longitudLados)
        {   
            NumeroLados = numeroLados;  
            LongitudLados = longitudLados;
        }
        
        public int NumeroLados { get; }
        public double LongitudLados { get; }
    }
}
