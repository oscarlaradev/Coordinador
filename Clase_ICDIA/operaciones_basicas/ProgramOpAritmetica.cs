namespace operaciones_basicas;

public class ProgramOpAritmetica
{
    public ProgramOpAritmetica()
    {

        ExpresionAritmetica expr; //declara el objeto
        
        //instancia el objeto (reserva memoria y asigna valores iniciales)
        expr = new ExpresionAritmetica(3, 4);

        int resultado = expr.Suma();
        
        Console.WriteLine(resultado);




    }
}