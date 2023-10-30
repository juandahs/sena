using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AreaPoligonoRegular
{
    internal class ExecutarPoligonoRegular
    {  

        public static void Ejecutar() 
        {

            Console.WriteLine("Por favor ingrese el número de lados del polígono."); 
            
            //Se valida la entrada del usuario. además debe ser mayor a 3 lados.
            if(!int.TryParse(Console.ReadLine(), out int numeroLados)) 
                numeroLados = 0;

            Console.WriteLine("Por favor ingrese la longitud de lados del polígono.");
            if (numeroLados < 3)
            {
                Console.WriteLine("Para cacular el área del poligono regular debe ser minimo de 3 lados.");
                Environment.Exit(0);
            }

            //Se valida la entrada del usuario. además debe ser mayor a 3 lados.
            if (!double.TryParse(Console.ReadLine(), out double longitudLados))
                longitudLados = 0;

            //Se valida la longitud de los lados.
            if (longitudLados <= 0)
            {
                Console.WriteLine("Para cacular el área del poligono la longitud no puedser igual o menor a 0");
                Environment.Exit(0);
            }

            Console.WriteLine($"El área del polígono regular de {numeroLados} y longitud {longitudLados} es de:");
            IFigura poligono = new Poligono(numeroLados, longitudLados);
            Console.WriteLine(poligono.Area);

        }
    }
}
