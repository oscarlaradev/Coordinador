namespace clase_definicion;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Programa clase_definicion iniciado correctamente.");
        GatoNuevo1 gato1 = new GatoNuevo1(1, "Michito", "Blanco", 3, true, 4.5);
        Console.WriteLine($"El nombre del gato es: {gato1.Nombre()}");
    }
}
