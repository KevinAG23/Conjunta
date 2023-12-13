using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Conjunta
{
    internal class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Calificacion { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine("\n\t\t-----------Ejercicio 4-----------\n");
            Console.WriteLine("\n\tEstudiante:");
            Console.WriteLine("\tNombre: " + Nombre);
            Console.WriteLine("\tEdad: " + Edad);
            Console.WriteLine("\tCalificación: " + Calificacion);
        }
    }
}
