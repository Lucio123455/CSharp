using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*2) Realizá un programa que permita al usuario ingresar 3 notas pertenecientes a tres trimestres
distintos para cierto alumno. La computadora debe mostrar la nota promedio.*/

namespace CSharp.GuiaUno
{
    internal class Ejercicio2
{
    public static void Ejecutar()
    {
        int nota1 = Utilidades.Utilidades.SolicitarEnteroEnRango("Ingrese la nota 1", 0, 10);
        int nota2 = Utilidades.Utilidades.SolicitarEnteroEnRango("Ingrese la nota 2", 0, 10);
        int nota3 = Utilidades.Utilidades.SolicitarEnteroEnRango("Ingrese la nota 3", 0, 10);

        float promedio = CalcularPromedio3Notas(nota1, nota2, nota3);

        Console.WriteLine($"El promedio de las notas es {promedio}");
    }

    private static float CalcularPromedio3Notas(int nota1, int nota2, int nota3)
    {
        return (nota1 + nota2 + nota3) / 3f;
    }
}
}
