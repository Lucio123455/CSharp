using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

namespace CSharp.Pruebas
{
    internal class Prueba1
    {
        public static void Ejecutar()
        {
            int entero = Utilidades.Utilidades.SolicitarEntero("Ingrese un entero");
            Console.WriteLine(entero); 
        }
    }
}
