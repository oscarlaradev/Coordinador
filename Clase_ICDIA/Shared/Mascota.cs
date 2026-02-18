using System.Runtime.CompilerServices;
namespace Shared;

public class Mascota
{
    private int id_mascota;
    private string nombre; //no se hace
    private string tipo_mascota;
    private string raza;
    private bool tiene_cartilla;
    private string nombre_cuidador; //no se hace
    private int edad;
    private bool tiene_chip;
    private double peso;
    private double tamanio;
    private string rasgo_caracteristico;  //no se hace

    #region contructores
    public Mascota (int id_mascota, string nombre, string tipo_mascota, string raza, bool tiene_cartilla, string nombre_cuidador, int edad, bool tiene_chip, double peso, double tamanio, string rasgo_caracteristico)
    {
        this.id_mascota = id_mascota;
        this.nombre = nombre;
        this.tipo_mascota = tipo_mascota;
        this.raza = raza;
        this.tiene_cartilla = tiene_cartilla;
        this.nombre_cuidador = nombre_cuidador;
        this.edad = edad;
        this.tiene_chip = tiene_chip;
        this.peso = peso;
        this.tamanio = tamanio;
        this.rasgo_caracteristico = rasgo_caracteristico;
    }
    #endregion

    public override string ToString()
    {
        string temporal = "(" + id_mascota + ")" + nombre + " - Cuidador:" + nombre_cuidador;
        return temporal;
    }

    #region Propiedades
    public double Peso
    {
        get => peso;
        set => peso = value;
    }

    public int Edad
    {
        get => edad;
        set => edad = value;
    }

    public double Tamanio
    {
        get => tamanio;
        set => tamanio = value;
    }


    public string Tipo_Mascota
    {
        get => tipo_mascota;
        set => tipo_mascota = value;
    }

    public string Raza
    {
        get => raza;
        set => raza = value;
    }

    public bool Tiene_Cartilla
    {
        get => tiene_cartilla;
        set => tiene_cartilla = value;
    }

    public bool Tiene_Chip
    {
        get => tiene_chip;
        set => tiene_chip = value;
    }

    public string Rasgo_Caracteristico
    {
        get => rasgo_caracteristico;
        set => rasgo_caracteristico = value;
    }

}
#endregion