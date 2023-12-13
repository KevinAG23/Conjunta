using System;

class Program
{
    static void Main()
    {
        Console.Write("\n\t\t-------------Ejercicio 2-------------\n\n");
        Console.Write("Ingresa tu edad: ");

        int edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad.");
        }
        else
        {
            Console.WriteLine("Eres menor de edad.");
        }

        Console.ReadKey();
    }
}
