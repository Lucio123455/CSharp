using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*7) Realizá un programa que permita al usuario ingresar tres números. La computadora debe
mostrarlos ordenados de menor a mayor.*/

namespace CSharp.GuiaDos
{
    internal class Ejercicio2_7
    {
        public static void Ejecutar()
        {
            int numeroA = Utilidades.Utilidades.SolicitarEntero("Ingrese un entero");
            int numeroB = Utilidades.Utilidades.SolicitarEntero("Ingrese un entero");
            int numeroC = Utilidades.Utilidades.SolicitarEntero("Ingrese un entero");
        }

        private static void MostrarNumerosDeMenorAMayor(int a, int b, int c)
        {
            
        }
    }
}
