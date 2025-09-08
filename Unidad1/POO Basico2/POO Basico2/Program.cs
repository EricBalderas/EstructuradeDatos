using POO_Basico2;

Libro miLibro = new Libro();
miLibro.Titulo = "";
miLibro.Autor = "";

Console.Write("Ingrese el titulo del libro: ");
miLibro.Titulo = Console.ReadLine();
Console.Write("Ingrese el autor del libro: ");
miLibro.Autor = Console.ReadLine();

miLibro.InfoLibro();