using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*19) Realizá un programa que permita al usuario ingresar dos números enteros que representen el 
ancho y el alto de una matriz de cruces. La computadora debe mostrar dicha matriz.*/

namespace CSharp.GuiaTres
{
    internal class Ejercicio3_19
    {
        public static void Ejecutar()
        {
            int largo = 10;
            int ancho = 15;

           MostrarMatriz(largo, ancho); 
        }

        private static void MostrarMatriz(int largo, int ancho)
        {
            for (int i = 0; i < largo; i++)
            {
                for (int j = 0;j < ancho; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
