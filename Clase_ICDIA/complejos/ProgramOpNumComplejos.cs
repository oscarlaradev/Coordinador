namespace complejos;

public class ProgramOpNumComplejos
{
    //Constructor vacio para la clase auxiliar
    public ProgramOpNumComplejos()
    { //logica del programa

        //Las palabras en gris de los argumentos son puestas
        //por el entorno de desarrollo, NO se ponen...
        NumeroComplejo z1 = new NumeroComplejo(2, 3);
        NumeroComplejo z2 = new NumeroComplejo(3, 4);

        NumeroComplejo zr = z1.Suma(z2);
        NumeroComplejo zr2 = z1.Resta(z2);
        NumeroComplejo zr3 = z1.Multiplicacion(z2);
        NumeroComplejo zr4 = z1.Division(z2);
        
        Console.WriteLine("z1 = " + z1);
        Console.WriteLine("z2 = " + z2);
        Console.WriteLine();
        Console.WriteLine("Suma: " + zr);
        Console.WriteLine("Resta: " + zr2);
        Console.WriteLine("Multiplicación: " + zr3);
        Console.WriteLine("División: " + zr4);
    }
}