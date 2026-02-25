namespace Telefonos;
using Shared;

public class OrdenamientoPorModelo : IComparer<Shared.Telefonos>
{
    public int Compare(Shared.Telefonos? x, Shared.Telefonos? y)
    {
        int v = x.Modelo.CompareTo(y.Modelo); // orden ascendente
        //int v = x.Modelo.CompareTo(y.Modelo) * -1; // orden descendente
        return v;
    }
}