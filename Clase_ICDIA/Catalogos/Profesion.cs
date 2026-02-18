namespace Clase_ICDIA_Unidad1;

// Clase para crear las profesiones
public class Profesion : IEquatable<Profesion>
{
    // Variables privadas para encapsular los datos de la profesión
    private string? nombreProfesion; // aqui guardo ej: Ing. de Datos
    private string idProfesion;      // este es el identificador unico

    // Constructor chido para cuando tengo todos los datos
    public Profesion(string idProfesion, string nombreProfesion)
    {
        this.idProfesion = idProfesion;
        this.nombreProfesion = nombreProfesion;
    }

    // Constructor auxiliar solo con el ID (para las busquedas)
    public Profesion(string idProfesion)
    {
        this.idProfesion = idProfesion;
    }
    
    // Propiedad para acceder al ID desde fuera
    public string IdProfesion
    {
        get => idProfesion; 
        set => idProfesion = value;
    }
    
    // Propiedad para el nombre
    public string? NombreProfesion
    {
        get => nombreProfesion; 
        set => nombreProfesion = value;
    }

    // Esto es para comparar objetos, si tienen el mismo ID son el mismo objeto
    public bool Equals(Profesion? other)
    {
        // uso el Equals del string para comparar los textos
        if (other == null) return false;
        return this.idProfesion.Equals(other.IdProfesion);
    }
    
    
    public override string ToString()
    {
        // Solo imprimo lo que si tengo guardado
        string cad = " Profesion: " + nombreProfesion +
        " ID: " + idProfesion;
        return cad;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Profesion);
    }

    public override int GetHashCode()
    {
        return idProfesion.GetHashCode();
    }
}
