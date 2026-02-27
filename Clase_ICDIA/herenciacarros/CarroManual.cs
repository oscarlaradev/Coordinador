namespace herenciacarros;

public class CarroManual : Carro
{
    public CarroManual(int nnserie) : base(nnserie)
    {
        
    }

    public override void Arrancar()
    {
        Console.WriteLine("Carro manual-Arranca");
    }
}