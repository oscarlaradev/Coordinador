namespace Zapato;

public class LogicaZapato
{
    public LogicaZapato()
    {
        Zapatos zapato1 = new Zapatos(146, "Converse", 23, 1200);
        Zapatos zapato2 = new Zapatos(160, "Nike", 28, 2500);
        Zapatos zapato3 = new Zapatos(157, "Adidas", 29, 2390);
        
        List<Zapatos> zzapatos = new List<Zapatos>();
        zzapatos.Add(zapato1);
        zzapatos.Add(zapato2);
        zzapatos.Add(zapato3);
        
        zzapatos.Sort();
        
        Console.WriteLine("Prueba:");
        foreach (Zapatos c in zzapatos)
        {
            Console.WriteLine(c);
        }
    }
    
}