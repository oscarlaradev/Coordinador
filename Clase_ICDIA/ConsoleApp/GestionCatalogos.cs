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
        profesiones = new List<Profesion>();   //cree la lista vacia para empezar a guardar las profesiones
        

        string op;
        do 
        {
            ImprimeMenu(); 
            // el ?? "" es para que si doy enter sin escribir no truene (me salia warning)
            op = Console.ReadLine() ?? ""; 

            switch (op)
            {
                case "1": // Opcion Agregar
                    AgregarProfesion(profesiones);
                    break; 
                case "2": // Opcion Modificar
                    if (profesiones.Count > 0) // Valido que la lista no este vacia
                    {
                        EditarProfesion();
                    }
                    else
                    {
                        Console.WriteLine("La lista de profesiones esta vacia");
                    }
                    break;
                case "3": // Opcion para Consultar
                    if (profesiones.Count > 0) // Valido antes de buscar
                    {
                        ConsultarProfesion();    // Ejecuta la consulta solo si hay profesiones registradas
                    }
                    else
                    {
                        Console.WriteLine("La lista de profesiones esta vacia");
                    }
                    
                    break;
                case "4": // Opcion Eliminar
                    if (profesiones.Count > 0)
                    { 
                        EliminarProfesion();
                    }
                    else
                    {
                        Console.WriteLine("La lista de profesiones esta vacia");
                    }

                    break;
                case "5": // Salir
                    Console.WriteLine("Que crack vuelvas pronto!");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        } while (!op.Equals("5"));  // Bucle que se repite hasta que op sea "5"

    }

// Método para agregar una nueva profesión a la lista
    public void AgregarProfesion(List<Profesion> profesiones)
    {
        string nombre, id; 
        // Solicito el nombre de la profesión al usuario
        Console.WriteLine("Dame el nombre de la profesion:");
        // Uso ?? para evitar valores nulos y asignar un texto por defecto
        nombre = Console.ReadLine() ?? "Sin nombre";
        
        bool idEsDisponible;
        Profesion temp;
        do
        {
            Console.WriteLine("Dame su ID:");
            id = Console.ReadLine() ?? "0";
            // Creo un objeto temporal con el ID ingresado para verificar si ya existe en la lista
             temp = new Profesion(id);
            // comprobamos si existe una profesion con el mismo ID usando Contains para la lista
            idEsDisponible = profesiones.Contains(temp);
            if (idEsDisponible){ 
                // Feedback para el usuario
                Console.WriteLine("El ID ya existe! Intenta con otro");
                return; // Me salgo para no duplicar
            }
        } while (idEsDisponible);
        
        // Si paso la validacion, asigno el nombre y guardo
        temp.NombreProfesion = nombre;
        profesiones.Add(temp); 

    }

    public void ConsultarProfesion()
    {
        Console.WriteLine("Ingrese el ID de la profesion a CONSULTAR:");
        string id = Console.ReadLine() ?? "";
        Profesion temp = new Profesion(id);
                        
        // Comprueba si el elemento existe en la lista
        bool result = profesiones.Contains(temp);
        if (result) // si es verdadero, osea si existe...
        {
            // busca en que posicion esta (indice 0, 1, 2 y asi) para despues imprimirlo
            int indice = profesiones.IndexOf(temp); 
            // Imprime usando el ToString que configure en la otra clase
            Console.WriteLine(profesiones[indice]);
        }
        else 
        {
            Console.WriteLine("No encontre ese ID.");
        }
    }

    public void EditarProfesion()
    {
        Console.WriteLine("Ingrese el ID de la profesion a EDITAR:");
        string id = Console.ReadLine() ?? "";
        Profesion temp = new Profesion(id);
                        
        // Comprueba si el elemento existe en la lista
        bool result = profesiones.Contains(temp);
        if (result) // si existe...
        {
            // necesito el indice para saber cual modificar
            int indice = profesiones.IndexOf(temp); 
            
            string nombre;
            Console.WriteLine("Ingresa el nuevo nombre de la profesion:");
            nombre = Console.ReadLine() ?? "";
            
            // actualiza solo el nombre, el ID no se toca
            profesiones[indice].NombreProfesion = nombre;
            
        }
        else 
        {
            Console.WriteLine("No existe ese ID para editar.");
        }
    }
    
    public void EliminarProfesion()
    {
        Console.WriteLine("Ingrese el ID de la profesion a ELIMINAR:");
        string id = Console.ReadLine() ?? "";

        Profesion temp = new Profesion(id);
                        
        // Comprueba si el elemento existe en la lista
        bool result = profesiones.Contains(temp);
        if (result) // si existeee
        {
            // lo borra de la lista
            profesiones.Remove(temp);
            Console.WriteLine("Profesion eliminada correctamente");
        }
        else 
        {
             Console.WriteLine("No encontre ese ID para borrar.");
        }
    }

}