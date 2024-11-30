using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*5) Realizá un programa que permita al usuario ingresar un número entero cant. Acto seguido, que
permita ingresar cant números reales, correspondientes a las ventas realizadas por cierto
vendedor. La computadora debe mostrar el total de las ventas*/

namespace CSharp.GuiaTres
{
    internal class Ejercicio3_5
    {
        public static void Ejecutar()
        {
            const int CANT = 3;
            int totalVentas = calcularTotalDeVentas(CANT);

            Console.WriteLine($"El total de ventas es {totalVentas}");
        }

        private static int calcularTotalDeVentas(int cant)
        {
            int total = 0;

            for (int i = 0; i < cant; i++)
            {
                total += Utilidades.Utilidades.SolicitarEntero($"Ingresa el valor de la venta {i + 1}");
            }

            return total;
        }
    }
}
