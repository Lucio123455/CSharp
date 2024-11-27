using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*6) Realizá un programa que permita al usuario ingresar el ancho y el largo de un terreno en metros
y el valor del metro cuadrado de tierra. La computadora debe mostrar el valor total del terreno y la
cantidad de metros de alambre que serían necesarios para cercarlo completamente en tres pasadas.*/

namespace CSharp.GuiaUno
{
    internal class Ejercicio6
    {
        public static void Ejecutar()
        {
            int ancho = Utilidades.Utilidades.SolicitarEnteroEnRango("Ingrese el ancho del terreno", 1, 10000000);
            int largo = Utilidades.Utilidades.SolicitarEnteroEnRango("Ingrese el largo del terreno", 1, 10000000);
            int valorMetroCuadrado = Utilidades.Utilidades.SolicitarEnteroEnRango("Ingrese el valor del metro cuadrado", 1, 10000000);

            int valorDelTerreno = calcularValorDelTerreno(ancho,largo,valorMetroCuadrado);
            int alambreTotal = calcularPerimetro2d(largo, ancho);

            Console.WriteLine($"El valor del terreno es {valorDelTerreno:C} y la cantidad de alambre necesario es {alambreTotal}m.");
        }

        private static int calcularValorDelTerreno(int ancho, int largo, int valorMetroCuadrado)
        {
            return ancho * largo * valorMetroCuadrado;
        }

        private static int calcularPerimetro2d(int largo, int ancho)
        {
            return ((largo * 2) + (ancho * 2)) * 3;
        }
    }
}
