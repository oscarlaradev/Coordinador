namespace Zapato;

public class Zapatos : IEquatable<Zapatos>, IComparable<Zapatos>
{
    private long code;
    private string marca;
    private int talla;
    private decimal precio;

    public Zapatos(long code, string marca, int talla, decimal precio)
    {
        this.code = code;
        this.marca = marca;
        this.talla = talla;
        this.precio = precio;
    }
    
    public long Code
    {
        get => code;
        set => code = value;
    }

    public string Marca
    {
        get => marca;
        set => marca = value;
    }

    public int Talla
    {
        get => talla;
        set => talla = value;
    }

    public decimal Precio
    {
        get => precio;
        set => precio = value;
    }

    public bool Equals(Zapatos? other)
    {
        if (other is null) return false;
        if (code == other.code)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int CompareTo(Zapatos? other)
    {
        int resultado = (int)(this.Code - other.code);
        return resultado;
    }
    
    public override string ToString()
    {
        string cad = "(" + code + ") " + "Marca: " + marca + " - " +
             "Talla: " + talla + " - " + "$"  + precio;
        return cad;
    }
}