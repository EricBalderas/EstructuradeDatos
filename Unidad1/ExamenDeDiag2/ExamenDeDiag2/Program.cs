using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDeDiag2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.WriteLine("Ingrese un valor entero positivo:");
            valor = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[valor];
            for (int i = 0; i < valor; i++)
            {
                Console.WriteLine("Ingrese el numero " + (i + 1) + ":");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }
            Console.WriteLine("La suma de los numeros es: " + suma);
        }
    }
}
