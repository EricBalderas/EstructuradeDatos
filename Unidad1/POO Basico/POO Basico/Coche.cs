using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Basico
{
	public class Coche
	{
		private string strMarca;

		public string Marca
		{
			get { return strMarca; }
			set { strMarca = value; }
		}

		private string strModelo;

		public string Modelo
		{
			get { return strModelo; }
			set { strModelo = value; }
		}

		private int intVelocidad;

		public int Velocidad
		{
			get { return intVelocidad; }
			set { intVelocidad = value; }
		}
		public void Acelerar()
		{
			do
			{
                intVelocidad += 10;
				Console.WriteLine($"Velocidad: {intVelocidad} km/h");
				System.Threading.Thread.Sleep(500);
            }
			while (intVelocidad < 240);

		}
		public void Frenar()
		{
            do
            {
                intVelocidad -= 10;
                Console.WriteLine($"Velocidad: {intVelocidad} km/h");
                System.Threading.Thread.Sleep(500);
            }
            while (intVelocidad > 0);
        }

    }
}
