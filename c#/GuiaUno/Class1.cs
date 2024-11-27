using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*1) Realizá un programa que permita al usuario ingresar un número entero. La computadora debe
informar el número opuesto1 y el número inverso2 del ingresado. */

namespace CSharp.GuiaUno
{
    public class Ejercicio1
    {
        public static void Ejecutar()
        {
            int numeroEntero = Utilidades.Utilidades.SolicitarEntero("Ingrese un número entero:");

            int numeroOpuesto = CalcularOpuestoDeUnNumero(numeroEntero);
            double numeroInverso = CalcularInversoDeUnNumero(numeroEntero);

            Console.WriteLine($"El número opuesto de {numeroEntero} es {numeroOpuesto}, y el inverso es {numeroInverso}");
        }

        private static int CalcularOpuestoDeUnNumero(int numero)
        {
            return -numero;
        }

        private static double CalcularInversoDeUnNumero(int numero)
        {
            if (numero == 0)
            {
                Console.WriteLine("El número ingresado es 0, por lo que no tiene inverso.");
                return 0; 
            }
            return 1.0 / numero;
        }
    }
}
