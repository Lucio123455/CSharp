using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*1) Realizá un programa que muestre todos los números enteros del 1 al 100, y luego, los mismos 
números, pero en orden inverso.*/

namespace CSharp.GuiaTres
{
    internal class Ejercicio3_1
    {
        public static void Ejecutar()
        {
            ContarDesde(1, 100);
            ContarDesde(100, 1);
        }

        private static void ContarDesde(int a, int b)
        {
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            } 
            else
            {
                for (int i = a; i >= b; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
