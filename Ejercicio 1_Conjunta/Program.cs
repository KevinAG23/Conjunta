using System;

class Program
{
    static void Main()
    {
        // 1. Declarar dos variables
        int num1;
        int num2;
        int resultado;
        Console.WriteLine("\t----------------Ejercicio 1----------------\n");

        Console.Write("Ingresa el primer número: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        resultado = num1 + num2;
       Console.WriteLine("La suma es: " + resultado);


        Console.ReadKey();
    }
}
