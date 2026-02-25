namespace Carros;

public class CarroOrdenamientoPorModelo : IComparer<Carro>
{
    public int Compare(Carro? x, Carro? y)
    {
        int v = x.Modelo - y.Modelo;
        return v;
    }
}