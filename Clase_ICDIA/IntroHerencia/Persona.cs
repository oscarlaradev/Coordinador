namespace IntroHerencia;

public class Persona
{
    private string nombre;
    private string mascota;
    private string carro;

    public Persona(string nombre)
    {
        this.nombre = nombre;
    }

    public string Nombre
    {
        get => nombre; 
        set => nombre = value;
    }
    public string Mascota
    {
        get => mascota;
        set => mascota = value;
    }

    public string Carro
    {
        get => carro;
        set => carro = value;
    }

    public void Saludar()
    {
        Console.WriteLine("Hola! mi nombre es " + Nombre);
    }
}