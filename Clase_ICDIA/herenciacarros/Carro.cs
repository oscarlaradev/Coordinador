namespace herenciacarros;

public class Carro
{
    private int num_serie;

    public int NumSerie
    {
        get => num_serie;
        set
        {
            if (value > 0)
            {
                num_serie = value;
            }
            else
            {
                //ENVIA ERROR AL USUARIO
            }
        }
    }
    
    public Carro(int numSerie)
    {
        NumSerie = numSerie;
    }

    public virtual void Arrancar()
    {
        Console.WriteLine("Enceder Carro--!");
    }

}