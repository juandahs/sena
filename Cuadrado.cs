

namespace ConsoleApp
{
    internal class Cuadrado : IFigura
    {   
        public Cuadrado(int numeroLados, double longitudLados)
        {
            NumeroLados = numeroLados;
            LongitudLados = longitudLados;  
        }
        
        public int NumeroLados { get; }
        public double LongitudLados { get; }

    }
}
