using Ejercicio_4_Conjunta;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\n\t\t-----------Ejercicio 4-----------\n");

        Console.Write("Ingrese el nombre del estudiante: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese la edad del estudiante: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la calificación del estudiante: ");
        double calificacion = double.Parse(Console.ReadLine());

        Console.Clear();

        Estudiante estudiante1 = new Estudiante
        {
            Nombre = nombre,
            Edad = edad,
            Calificacion = calificacion
        };

        estudiante1.MostrarInformacion();

        Console.ReadKey();
    }
}