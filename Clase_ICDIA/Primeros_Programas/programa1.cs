namespace Primeros_Programas;
public class programa1
{
    public programa1()
    {
        //Alumno alumnos[];

        //Arreglo dinamico utilizando la estructura 
        //que nos proporciona C#
        List<Alumno> alumnos;
        alumnos = new List<Alumno>();

        string op;
        string auxiliar1, auxiliar2;
        do
        {
            Console.WriteLine("Desea agregar algún alumno? (s = si)");
            op = Console.ReadLine();
            if (op.Equals("s"))
            {
                Console.WriteLine("Dame el nombre del alumno:");
                auxiliar1 = Console.ReadLine();
                Console.WriteLine("Dame su matricula:");
                auxiliar2 = Console.ReadLine();
                Alumno al = new Alumno(auxiliar2, auxiliar1);
                alumnos.Add(al); //agrega al objeto creado en la lista de alumnos
            }
        } while (!op.Equals("n"));
        Console.WriteLine("Gracias por usar el programa!!");


    }
}