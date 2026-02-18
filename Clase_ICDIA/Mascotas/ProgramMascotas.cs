using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace EjemeploMacota
{
    public class ProgramMascotas
    {

        public ProgramMascotas()
        {
            ArrayList mascotas = new ArrayList();

            //1
            mascotas.Add(new Mascota(1, "Martina", "Perra", "Chihuahua", true, "Oscar", 8, true, 2.5, 30, "tranquila"));

            //2
            mascotas.Add(new Mascota(2, "Rocco", "Perro", "Pastor Alemán", true, "Elena", 4, true, 32.0, 65, "protector"));

            //3
            mascotas.Add(new Mascota(3, "Mimi", "Gata", "Persa", true, "Luis", 2, true, 4.2, 25, "perezosa"));

            //4
            mascotas.Add(new Mascota(4, "Oliver", "Gato", "Maine Coon", false, "Sofía", 5, true, 8.5, 40, "curioso"));

            //5
            mascotas.Add(new Mascota(5, "Burbuja", "Pez", "Goldfish", false, "Andrés", 1, true, 0.1, 5, "asustadizo"));

            //6
            mascotas.Add(new Mascota(6, "Rex", "Reptil", "Iguana", true, "Claudia", 3, true, 5.0, 120, "indiferente"));

            //7
            mascotas.Add(new Mascota(7, "Pelusa", "Conejo", "Angora", true, "Marta", 2, true, 1.8, 20, "miedoso"));

            //8
            mascotas.Add(new Mascota(8, "Thor", "Perro", "Husky", true, "Roberto", 6, true, 25.4, 55, "energético"));

            //9
            mascotas.Add(new Mascota(9, "Luna", "Gata", "Siamés", true, "Beatriz", 7, false, 3.8, 28, "cariñosa"));

            //10
            mascotas.Add(new Mascota(10, "Coco", "Ave", "Loro", false, "Javier", 12, true, 0.5, 35, "parlanchín"));

            // Imprimir todas las mascotas registradas
            Console.WriteLine("\n--- mascotas registradas ---");

            foreach (Mascota mascota in mascotas)
            {
                Console.WriteLine(mascota);
            }


            // 1. Imprimir a las mascotas que tienen menos de x kilos
            double pesoLimite = 5;
            Console.WriteLine("\n--- mascotas con menos de " + pesoLimite + "kilos:");

            foreach (Mascota mascota in mascotas)
            {
                if (mascota.Peso <= pesoLimite)
                {
                    Console.WriteLine(mascota);
                }
            }


            // 2. imprimir a las mascotas que tienen menos de x años 
            int edadReferencia = 3;
            Console.WriteLine("\n--- mascotas con " + edadReferencia + " años o menos");

            foreach(Mascota mascota in mascotas)
            {
                if(mascota.Edad <= edadReferencia)
                {
                    Console.WriteLine(mascota);
                }
            }


            // 3. Imprimir mascotas con tamaño menor o igual a un valor específico
            double tamanioMascota = 20;
            Console.WriteLine("\n--- mascota con: " + tamanioMascota + " de tamanio");

            foreach(Mascota mascota in mascotas)
            {
                if (mascota.Tamanio <= tamanioMascota)
                {
                    Console.WriteLine(mascota);
                }
            }

            // 4. Filtrar por Tipo de Mascota (ej. solo Perros)
            string tipoBuscar = "Perro";
            Console.WriteLine("\n--- Mascotas de tipo: " + tipoBuscar + " ---");
            foreach (Mascota mascota in mascotas)
            {
                if (mascota.Tipo_Mascota == tipoBuscar || mascota.Tipo_Mascota == "Perra")
                {
                    Console.WriteLine(mascota);
                }
            }

            // 5. Filtrar por Raza
            string razaBuscar = "Persa";
            Console.WriteLine("\n--- Mascotas de raza: " + razaBuscar + " ---");
            foreach (Mascota mascota in mascotas)
            {
                if (mascota.Raza == razaBuscar)
                {
                    Console.WriteLine(mascota);
                }
            }

            // 6. Filtrar por Cartilla (solo las que tienen)
            Console.WriteLine("\n--- Mascotas con Cartilla de Vacunación ---");
            foreach (Mascota mascota in mascotas)
            {
                if (mascota.Tiene_Cartilla == true)
                {
                    Console.WriteLine(mascota);
                }
            }

            // 7. Filtrar por Chip (solo las que tienen)
            Console.WriteLine("\n--- Mascotas con Chip de identificación ---");
            foreach (Mascota mascota in mascotas)
            {
                if (mascota.Tiene_Chip == true)
                {
                    Console.WriteLine(mascota);
                }
            }

            // 8. Filtrar por Rasgo Característico
            string rasgoBuscar = "tranquila";
            Console.WriteLine("\n--- Mascotas con rasgo: " + rasgoBuscar + " ---");
            foreach (Mascota mascota in mascotas)
            {
                if (mascota.Rasgo_Caracteristico == rasgoBuscar)
                {
                    Console.WriteLine(mascota);
                }
            }
        }
    }
}
