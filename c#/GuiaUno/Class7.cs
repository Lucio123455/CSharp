using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*7) Realizá un programa que permita al usuario ingresar dos números enteros. La computadora debe
mostrar los resultados de las 4 operaciones matemáticas básicas con tales números.*/

namespace CSharp.GuiaUno
{
    internal class Ejercicio7
    {
        public static void Ejecutar()
        {
            int numeroA = Utilidades.Utilidades.SolicitarEntero("Ingrese un entero");
            int numeroB = Utilidades.Utilidades.SolicitarEntero("Ingrese un entero");

            Console.WriteLine($"La suma entre {numeroA} y {numeroB} es {suma(numeroA, numeroB)}");
            Console.WriteLine($"La resta entre {numeroA} y {numeroB} es {resta(numeroA, numeroB)}");
            Console.WriteLine($"La multiplicacion entre {numeroA} y {numeroB} es {multiplicacion(numeroA, numeroB)}");
            Console.WriteLine($"La division entre {numeroA} y {numeroB} es {division(numeroA, numeroB)}");
        }

        private static int suma(int a, int b)
        {
            return a + b;
        }

        private static int resta(int a, int b)
        {
            return a - b;
        }

        private static int multiplicacion(int a, int b)
        {
            return a * b;
        }

        private static float division(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("No es posible dividir por 0");
            }
            return (float)a / b;
        }
    }
}
