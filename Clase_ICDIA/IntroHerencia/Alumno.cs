namespace IntroHerencia;

public class Alumno : Persona
{
    

    public Alumno(string nombre) 
        : base(nombre)
    {
        
    }

    /*
    public override void Saludar()
    {
        Console.WriteLine(
            "Hola! mi nombre es " 
            + Nombre);
    }
    */

    public override string ToString()
    {
        return "";
    }
}