using System.Collections;
using System;

namespace Telefonos;

public class LogicaTelefonos
{
    public LogicaTelefonos()
    {
        List<Shared.Telefonos> listaTelefonos = new List<Shared.Telefonos>();

        listaTelefonos.Add(new Shared.Telefonos(1, "Apple", "iPhone 13 Pro Max", "iOS", 6.7, 4352, true, true, "Space Gray"));
        listaTelefonos.Add(new Shared.Telefonos(2, "Samsung", "Galaxy S21 Ultra", "Android", 6.8, 12000, true, true, "Phantom Black"));
        listaTelefonos.Add(new Shared.Telefonos(3, "Google", "Pixel 6 Pro", "Android", 6.7, 5000, true, true, "Stormy Black"));
        listaTelefonos.Add(new Shared.Telefonos(4, "OnePlus", "OnePlus 9 Pro", "Android", 6.7, 4500, true, true, "Pine Green"));
        listaTelefonos.Add(new Shared.Telefonos(5, "Xiaomi", "Mi 11 Ultra", "Android", 6.81, 5000, true, true, "Ceramic White"));
        listaTelefonos.Add(new Shared.Telefonos(6, "Sony", "Xperia 1 III", "Android", 6.5, 4500, true, true, "Frosted Black"));

        List<Shared.Telefonos> listaTelefonos2 = new List<Shared.Telefonos>();

        listaTelefonos2.Add(new Shared.Telefonos(1, "Apple", "iPhone 13 Pro Max", "iOS", 6.7, 4352, true, true, "Space Gray"));
        listaTelefonos2.Add(new Shared.Telefonos(2, "Samsung", "Galaxy S21 Ultra", "Android", 6.8, 12000, true, true, "Phantom Black"));
        listaTelefonos2.Add(new Shared.Telefonos(3, "Google", "Pixel 6 Pro", "Android", 6.7, 5000, true, true, "Stormy Black"));
        listaTelefonos2.Add(new Shared.Telefonos(4, "OnePlus", "OnePlus 9 Pro", "Android", 6.7, 4500, true, true, "Pine Green"));
        listaTelefonos2.Add(new Shared.Telefonos(5, "Xiaomi", "Mi 11 Ultra", "Android", 6.81, 5000, true, true, "Ceramic White"));
        listaTelefonos2.Add(new Shared.Telefonos(6, "Sony", "Xperia 1 III", "Android", 6.5, 4500, true, true, "Frosted Black"));

        Console.WriteLine("Lista de teléfonos:");
        // ordena la lista por marca
        OrdenamientoPorMarca ordenamiento = new OrdenamientoPorMarca();
        listaTelefonos.Sort(ordenamiento);
        //ordena la lista por modelo
        OrdenamientoPorModelo ordenamientoModelo = new OrdenamientoPorModelo();
        listaTelefonos2.Sort(ordenamientoModelo);

        Console.WriteLine("\nLista de teléfonos ordenada por Marca (ascendente):");

        foreach (Shared.Telefonos telefono in listaTelefonos)
        {
            Console.WriteLine(telefono);
        }

        Console.WriteLine("\nLista de teléfonos ordenada por Modelo (ascendente):");
        foreach (Shared.Telefonos telefono2 in listaTelefonos2)
        {
            Console.WriteLine(telefono2);
        }

    }
}