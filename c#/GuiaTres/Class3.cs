using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*3) Realizá un programa que permita al usuario ingresar un número entero n entre 1 y 10. La 
computadora debe mostrar la tabla de multiplicar de n.*/

namespace CSharp.GuiaTres
{
    internal class Ejercicio3_3
    {
        public static void Ejecutar()
        {
            TablaDeN(5);
        }

        private static void TablaDeN(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {n} = {i * n}");
            }
        }
    }
}
