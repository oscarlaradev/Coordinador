namespace Telefonos;
using Shared;

public class OrdenamientoPorMarca : IComparer<Shared.Telefonos>
{
    public int Compare(Shared.Telefonos? x, Shared.Telefonos? y)
    {
        int v = x.Marca.CompareTo(y.Marca); // orden ascendente
        //int v = x.Marca.CompareTo(y.Marca) * -1; // orden descendente
        return v;
    }
}