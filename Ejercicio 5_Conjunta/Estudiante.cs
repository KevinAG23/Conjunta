using System;

namespace Ejercicio_5_Conjunta
{
    internal class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Calificacion { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("\n\t\t-----------Ejercicio 5-----------\n");
            Console.WriteLine("\n\tEstudiante:");
            Console.WriteLine("\tNombre: " + Nombre);
            Console.WriteLine("\tEdad: " + Edad);
            Console.WriteLine("\tCalificación: " + Calificacion);
        }
    }
}
