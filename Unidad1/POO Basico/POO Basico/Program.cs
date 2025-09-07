using POO_Basico;

Coche micoche = new Coche();
micoche.Marca = "";
micoche.Modelo = "";
micoche.Velocidad = 0;

Console.WriteLine("Introduce la marca del coche:");
micoche.Marca = Console.ReadLine();
Console.WriteLine("Introduce el modelo del coche:");
micoche.Modelo = Console.ReadLine();
Console.WriteLine("Introduce la velocidad del coche (km/h):");
micoche.Velocidad = int.Parse(Console.ReadLine());

Console.WriteLine($"Marca: {micoche.Marca}, Modelo: {micoche.Modelo}, Velocidad: {micoche.Velocidad} km/h");

//Presiona 1 sieres acelerar el coche, 2 si quieres frenar el coche
Console.WriteLine("Presiona 1 si quieres acelerar el coche, 2 si quieres frenar el coche:");
string opcion = Console.ReadLine();
if (opcion == "1")
{
    micoche.Acelerar();
}
else if (opcion == "2")
{
    micoche.Frenar();
}
else
{
    Console.WriteLine("Opción no válida.");
}