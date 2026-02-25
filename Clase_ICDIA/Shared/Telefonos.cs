using System.Runtime.CompilerServices;
namespace Shared;

public class Telefonos : IEquatable<Telefonos>, IComparable<Telefonos>
{
    private int id_telefono;
    private string marca;
    private string modelo;
    private string sistema_operativo;
    private double tamanio_pantalla;
    private int capacidad_bateria;
    private bool tiene_carga_rapida;
    private bool tiene_5g;
    private string color;


public bool Equals(Telefonos? other)
    {
        if (other is null) return false;
        if (id_telefono == other.id_telefono)
        {
            //LOG
            return true;
        }
        else
        {
            //LOG
            return false;
        }
    }
    public int CompareTo(Telefonos? other)
    {
        int v = this.id_telefono.CompareTo(other.id_telefono);
        return v;
    }

    #region constructores
    public Telefonos()
    {

    }
    public Telefonos(int id_telefono, string marca, string modelo, string sistema_operativo, double tamanio_pantalla, int capacidad_bateria, bool tiene_carga_rapida, bool tiene_5g, string color)
    {
        this.id_telefono = id_telefono;
        this.marca = marca;
        this.modelo = modelo;
        this.sistema_operativo = sistema_operativo;
        this.tamanio_pantalla = tamanio_pantalla;
        this.capacidad_bateria = capacidad_bateria;
        this.tiene_carga_rapida = tiene_carga_rapida;
        this.tiene_5g = tiene_5g;
        this.color = color;
    }
    #endregion

    public override string ToString()
    {
        string temporal = id_telefono + " - " + marca + " - " + modelo + " - " + sistema_operativo + " - " + color;
        return temporal;
    }

    #region Propiedades

    public int IdTelefono
    {
        get => id_telefono;
        set => id_telefono = value;
    }
    public string Marca
    {
        get => marca;
        set => marca = value;
    }

    public string Modelo
    {
        get => modelo;
        set => modelo = value;
    }

    public string SistemaOperativo
    {
        get => sistema_operativo;
        set => sistema_operativo = value;
    }

    public double TamanioPantalla
    {
        get => tamanio_pantalla;
        set => tamanio_pantalla = value;
    }

    public int CapacidadBateria
    {
        get => capacidad_bateria;
        set => capacidad_bateria = value;
    }

    public bool TieneCargaRapida
    {
        get => tiene_carga_rapida;
        set => tiene_carga_rapida = value;
    }

    public bool Tiene5G
    {
        get => tiene_5g;
        set => tiene_5g = value;
    }

    public string Color
    {
        get => color;
        set => color = value;
    }

    #endregion

}