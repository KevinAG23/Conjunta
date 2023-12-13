using System;

namespace Ejercicio_5_Conjunta
{
    internal class EstudianteGraduado : Estudiante
    {
        public string Titulo { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();

            Console.WriteLine("\tTítulo obtenido: " + Titulo);
        }
    }
}
