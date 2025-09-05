using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaElNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101); 
            int numeroUsuario = 0;
            int intentos = 0; 
            int vidas = 10; 
            Console.WriteLine("Bienvenido al juego de adivinar el nmero!");
            Console.WriteLine("Adivina el numero aleatorio entre 1 y 100, ¡¡¡¡tienes 10 vidas!!!");

            Console.Write("Introduce tu numero: ");


            while (numeroUsuario != numeroAleatorio && vidas > 0)
            {

                try
                {
                    numeroUsuario = int.Parse(Console.ReadLine());
                    intentos++;
                    vidas--;

                    if (numeroUsuario < numeroAleatorio)
                    {
                        Console.WriteLine("El numero a adivinar es mayor, intenta de nuevo:");
                        Console.WriteLine("Te quedan: " + vidas + " vidas");
                        Console.WriteLine("Introduce tu numero: ");
                    }
                    else
                    {
                        Console.WriteLine("El numero a adivinar es menor, intenta de nuevo:");
                        Console.WriteLine("Te quedan: " + vidas + " vidas");
                        Console.WriteLine("Introduce tu numero: ");
                    }
                    
                }

                catch (FormatException)
                {
                    Console.WriteLine("Error, introduce un numero entero.");
                    Console.WriteLine("Te quedan: " + vidas + " vidas");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error, el numero es demasiado grande o demasiado pequeño.");
                    Console.Write("Introduce tu numero: ");
                    Console.WriteLine("Te quedan: " + vidas + " vidas");
                }

                
            }

            if (numeroUsuario == numeroAleatorio)
            {
                Console.WriteLine("Felicidades, has adivinado el numero en " + intentos + " intentos!");

            }
            else
            {
                Console.WriteLine("Lo siento, has perdido. El numero era: " + numeroAleatorio);

            }
        }
    }
}
