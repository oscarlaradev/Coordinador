using System.Runtime.CompilerServices;
namespace Shared;

public class Persona
{
    private int ssn;
    private string? nombre; //no se hace
    private int edad;
    private bool tiene_mascota;
    private Mascota? mascota;

    #region constructores

    public Persona()
    {
        
    }
    public Persona(int ssn, string nombre, int edad, bool tiene_mascota , Mascota mascota)
    {
        this.ssn = ssn;
        this.nombre = nombre;
        this.edad = edad;
        this.tiene_mascota = tiene_mascota;
        this.mascota = mascota;
    }

    public Persona(int ssn)
    {
        this.ssn = ssn;
    }

    #endregion

    #region Propiedades
    public int Ssn
    {
        get => ssn;
        set => ssn = value;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public int Edad
    {
        get => edad;
        set => edad = value;
    }

    public bool TieneMascota
    {
        get => tiene_mascota;
        set => tiene_mascota = value;
    }

    public Mascota Mascota
    {
        get => mascota;
        set => mascota = value;
    }
    #endregion

     public override string ToString()
    {
        string temporal = "(" + ssn + ")" + nombre + " - Edad:" + edad + " años";
        if (tiene_mascota)
        {
            temporal += " - Tiene mascota: " + mascota.ToString();
        }
        else
        {
            temporal += " - No tiene mascota";
        }
        return temporal;
    }
}