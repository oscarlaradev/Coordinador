namespace Clase_ICDIA_Unidad1;

public class GestionCatalogos {

    // Lista donde se guardan las profesiones en memoria
    List<Profesion> profesiones;
    
    public void ImprimeMenu()
    {
        Console.WriteLine("Selecciona la opcion deseada:");
        Console.WriteLine("1. Ingresar una profesion"); 
        Console.WriteLine("2. Modificar una profesion");
        Console.WriteLine("3. Consultar una profesion"); 
        Console.WriteLine("4. Eliminar una profesion"); 
        Console.WriteLine("5. Salir");
    }
    
    // Constructor donde corre todo el ciclo del menu
    public GestionCatalogos() 
    {
        profesiones = new List<Profesion>();

        string op;
        do 
        {
            ImprimeMenu(); 
            op = Console.ReadLine() ?? ""; 

            switch (op)
            {
                case "1":
                    AgregarProfesion(profesiones);
                    break; 
                case "2":
                    if (profesiones.Count > 0)
                    {
                        EditarProfesion();
                    }
                    else
                    {
                        Console.WriteLine("La lista de profesiones esta vacia");
                    }
                    break;
                case "3":
                    if (profesiones.Count > 0)
                    {
                        ConsultarProfesion();
                    }
                    else
                    {
                        Console.WriteLine("La lista de profesiones esta vacia");
                    }
                    break;
                case "4":
                    if (profesiones.Count > 0)
                    { 
                        EliminarProfesion();
                    }
                    else
                    {
                        Console.WriteLine("La lista de profesiones esta vacia");
                    }
                    break;
                case "5":
                    Console.WriteLine("Que crack vuelvas pronto!");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        } while (!op.Equals("5"));
    }

    public void AgregarProfesion(List<Profesion> profesiones)
    {
        string nombre, id; 
        Console.WriteLine("Dame el nombre de la profesion:");
        nombre = Console.ReadLine() ?? "Sin nombre";
        
        bool idEsDisponible;
        Profesion temp;
        do
        {
            Console.WriteLine("Dame su ID:");
            id = Console.ReadLine() ?? "0";
            temp = new Profesion(id);
            idEsDisponible = profesiones.Contains(temp);
            if (idEsDisponible){ 
                Console.WriteLine("El ID ya existe! Intenta con otro");
            }
        } while (idEsDisponible);

        profesiones.Add(new Profesion(id, nombre));
        Console.WriteLine("Profesion agregada!");
    }

    public void EditarProfesion()
    {
        Console.WriteLine("Dame el ID de la profesion a modificar:");
        string id = Console.ReadLine() ?? "";
        
        Profesion temp = new Profesion(id);
        int indice = profesiones.IndexOf(temp);
        
        if (indice != -1)
        {
            Console.WriteLine("Nuevo nombre:");
            string nuevoNombre = Console.ReadLine() ?? "";
            profesiones[indice].NombreProfesion = nuevoNombre;
            Console.WriteLine("Profesion modificada!");
        }
        else
        {
            Console.WriteLine("Profesion no encontrada");
        }
    }

    public void ConsultarProfesion()
    {
        foreach (Profesion p in profesiones)
        {
            Console.WriteLine(p);
        }
    }

    public void EliminarProfesion()
    {
        Console.WriteLine("Dame el ID de la profesion a eliminar:");
        string id = Console.ReadLine() ?? "";
        
        Profesion temp = new Profesion(id);
        if (profesiones.Remove(temp))
        {
            Console.WriteLine("Profesion eliminada!");
        }
        else
        {
            Console.WriteLine("Profesion no encontrada");
        }
    }
}
