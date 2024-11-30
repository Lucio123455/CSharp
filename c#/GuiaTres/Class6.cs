using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*6) Realizá un programa que permita al usuario ingresar un número entero cant. Acto seguido, que
permita ingresar cant números reales, correspondientes a las estaturas de un equipo de jugadores
de baloncesto (en metros). La computadora debe mostrar la estatura promedio.*/

namespace CSharp.GuiaTres
{
    internal class Ejercicio3_6
    {
        public static void Ejecutar()
        {
            const int CANT = 5;
            float promedioAltura = CalcularPromedioAltura(CANT);

            Console.WriteLine($"El promedio de altura {promedioAltura}");
        }

        private static float CalcularPromedioAltura(int cant)
        {
            float total = 0;

            for (int i = 0; i < cant; i++)
            {
                total += Utilidades.Utilidades.SolicitarFloat($"Ingrese la altura del juegador {i + 1}");
            }

            return total / cant;
        }
    }
}
