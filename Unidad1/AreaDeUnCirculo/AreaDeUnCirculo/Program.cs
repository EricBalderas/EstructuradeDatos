using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaDeUnCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el radio del circulo:");
            double radio = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine("El area del circulo es: " + area);
        }
    }
}
