using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Basico2
{
    internal class Libro
    {
		private string strTitulo;

		public string Titulo
		{
			get { return strTitulo; }
			set { strTitulo = value; }
		}
		private string strAutor;

		public string Autor
		{
			get { return strAutor;; }
			set { strAutor = value; }
		}

		public void InfoLibro ()
		{
			Console.WriteLine("Libro: " + Titulo +  "\nAutor: " + Autor);
        }

    }
}
