using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*2) Realizá un programa que permita al usuario ingresar dos números enteros num1 y num2, donde el 
primero siempre deberá ser menor o igual al segundo. La computadora debe mostrar la secuencia 
de números existentes entre ambos: 
A) Incluyéndolos. B) Excluyéndolos*/

namespace CSharp.GuiaTres
{
    internal class Ejercicio3_2
    {
        public static void Ejecutar()
        {
            NumerosEntreAyB(45, 32);
        }

        private static void NumerosEntreAyB(int a, int b)
        {
            if (!(a >= b))
            {
                for (int i = a + 1; i < b; i++)
                {
                    Console.WriteLine(i); 
                }
            }
            else
            {
                Console.WriteLine("ERROR. el segundo debe ser mayor al primero");
            }
        }
    }
}
