using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

namespace CSharp.Parciales.p1_androide
{
    internal class p1_Androide
    {
        public static void Ejecutar()
        {
            const int CANTIDAD_MAXIMA = 10;
            int cantTotal = 0;
            int cantGrupo = 0;
            int contGrupos = 0;
            float menorPromedioEdad = float.MaxValue;
            float promedioEdadGrupo = 0;
            int posicionDelMenorPromEdad = 0;

            while (cantTotal < 10)
            {
                cantGrupo = Utilidades.Utilidades.SolicitarEnteroEnRango("Ingrese la cantidad del grupo", 1, 4);
                if (cantTotal + cantGrupo <= 10)
                {
                    cantTotal += cantGrupo;
                    contGrupos++;

                    promedioEdadGrupo = CalcularPromedioEdad(cantGrupo);

                    if (promedioEdadGrupo < menorPromedioEdad)
                    {
                        menorPromedioEdad = promedioEdadGrupo;
                        posicionDelMenorPromEdad = contGrupos;
                    }

                    Console.WriteLine(promedioEdadGrupo);
                }
                else
                {
                    Console.WriteLine($"La atracción solo permite hasta {CANTIDAD_MAXIMA} personas. Quedan {CANTIDAD_MAXIMA - cantTotal} lugares disponibles. Por favor, intente con un grupo más pequeño.");
                } 
            }

            Console.WriteLine($"Ya llegamos a {cantTotal}, en {contGrupos} grupos " +
                $"El grupo con menor promedio de edad fue el {posicionDelMenorPromEdad}");
        }

        private static float CalcularPromedioEdad(int cantGrupo)
        {
            int totalEdad = 0;

            for (int i = 0; i < cantGrupo; i++)
            {
                totalEdad += Utilidades.Utilidades.SolicitarEnteroEnRango($"Ingrese la edad del {i + 1} integrante", 0, 120);
            }

            return (float)totalEdad / cantGrupo;
        }
    }
}
