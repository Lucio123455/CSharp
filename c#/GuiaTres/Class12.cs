using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*20) Realizá un programa que permita al usuario ingresar un número de minutos. La computadora 
debe mostrar un cronómetro con el formato "mm:ss" desde "00:00" hasta un segundo antes del 
minuto ingresado.*/

namespace CSharp.GuiaTres
{
    internal class Ejercicio3_20
    {
        public static void Ejecutar()
        {
            int minuto = 2;

            MostrarCronometro(minuto);
        }

        private static void MostrarCronometro(int minuto)
        {
            for (int i = 0; i < minuto; i++)
            {
                for (int j = 0; j < 60;j++)
                {
                    if (i < 10 && j < 10)
                    {
                        Console.WriteLine($"0{i}:0{j}");
                    } else if (i < 10 && j >= 10)
                    {
                        Console.WriteLine($"0{i}:{j}");
                    } else if (i >= 10 && j < 10)
                    {
                        Console.WriteLine($"{i}:0{j}");
                    }
                    else if (i >= 10 && j >= 10)
                    {
                        Console.WriteLine($"{i}:{j}");
                    }
                }
            }
        }
    }
}
