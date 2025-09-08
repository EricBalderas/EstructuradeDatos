using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.Write("¿Cuántos números quieres ingresar? ");
        int cantidad = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int numero = int.Parse(Console.ReadLine());
            numeros.Add(numero);
        }

        double promedio = CalcularPromedio(numeros);

        Console.WriteLine($"El promedio es: {promedio}");
    }

    static double CalcularPromedio(List<int> lista)
    {
        if (lista.Count == 0) return 0;

        int suma = 0;
        foreach (int num in lista)
        {
            suma += num;
        }

        return (double)suma / lista.Count;
    }
}
