using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*8) Realizá un programa que permita al usuario ingresar dos números enteros, que representan las 
medidas en grados de dos ángulos interiores de cierto triángulo. La computadora debe mostrar el 
valor en grados del ángulo restante.*/

namespace CSharp.GuiaUno
{
    internal class Ejercicio8
    {
        public static void Ejecutar()
        {
            int anguloA = Utilidades.Utilidades.SolicitarEnteroEnRango("Ingrese el valor en grados de un angulo del triangulo", 1, 100000000);
            int anguloB = Utilidades.Utilidades.SolicitarEnteroEnRango("Ingrese el valor en grados de otro angulo del triangulo", 1, 100000000);
            float anguloC = calcularAnguloRestante(anguloA, anguloB);
            Console.WriteLine($"El valor del angulo faltante es {anguloC}");
        }

        private static float calcularAnguloRestante(int anguloA, int anguloB)
        {
            const int SUMA_ANGULOS_TRIANGULO = 180;
            return 180 - anguloA - anguloB;
        }
    }
}
