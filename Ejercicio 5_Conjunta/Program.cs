using Ejercicio_5_Conjunta;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\n\t\t-----------Ejercicio 5-----------\n");

        Console.Write("Ingrese el nombre del estudiante: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese la edad del estudiante: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la calificación del estudiante: ");
        double calificacion = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el título obtenido: ");
        string titulo = Console.ReadLine();

        EstudianteGraduado graduado1 = new EstudianteGraduado
        {
            Nombre = nombre,
            Edad = edad,
            Calificacion = calificacion,
            Titulo = titulo
        };

        Console.Clear();
        graduado1.MostrarInformacion();

        Console.ReadKey();
    }
}
