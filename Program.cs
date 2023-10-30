// See https://aka.ms/new-console-template for more information
namespace ConsoleApp
{
    public static class Program 
    {
        static void Main(string[] args)
        {
            IFigura cuadrado = new Cuadrado(4, 2.0);
            IFigura triangulo = new Triangulo(4, 2.0);
            IFigura pentagono = new Pentagono(4, 2.0);            

            Console.WriteLine(pentagono.Area);
            Console.WriteLine(triangulo.Area);
            Console.WriteLine(cuadrado.Area);

        }
    }
    
}

