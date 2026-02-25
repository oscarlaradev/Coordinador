namespace Carros;

public class CarroOrdenamientoPorMarca : IComparer<Carro>
{
    public int Compare(Carro? x, Carro? y)
    {
        int v = x.Marca.CompareTo(y.Marca) * -1;
        return v;
    }
}