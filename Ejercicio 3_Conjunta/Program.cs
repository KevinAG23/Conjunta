using Ejercicio_3_Conjunta;

class Program
{
    static void Main()
    {
        
        Estudiante estudiante1 = new Estudiante
        {
            Nombre = "Kevin Alexander Guzman",
            Edad = 20,
            Calificacion = 18
        };

        Console.WriteLine("\n\t\t-----------Ejercicio 3-----------\n\n");
        Console.WriteLine("\tEstudiante:\n");
        Console.WriteLine("\tNombre: " + estudiante1.Nombre);
        Console.WriteLine("\tEdad: " + estudiante1.Edad);
        Console.WriteLine("\tCalificación: " + estudiante1.Calificacion);

        Console.ReadKey();
    }
}