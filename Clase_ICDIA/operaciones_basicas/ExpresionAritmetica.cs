namespace operaciones_basicas;

public class ExpresionAritmetica
{
    private int a;
    private int b;

    //Constructor Vacio
    public ExpresionAritmetica()
    {
   
    }

    public ExpresionAritmetica(int a, int b) //Valores externos que entran al método
    {
        //crea un objeto, y le da valores iniciales a ambos parametros
        this.a = a;
        this.b = b;
    }

    public int Suma()
    {
        return this.a + this.b;
    }


}