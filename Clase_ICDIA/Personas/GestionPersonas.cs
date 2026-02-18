using System.Runtime.CompilerServices;
using System.Collections;
using System;
using Shared;

namespace EjemeploMacota
{
    public class GestionPersonas
    {
        public GestionPersonas()
        {
            Persona pp1 = new Persona();

            pp1.Ssn = 123456789;
            pp1.Nombre = "Juan Perez";
            pp1.Edad = 30;
            pp1.TieneMascota = true;

            Mascota mascotita = new Mascota(1, "Firulais", "Perro", "Labrador", true, "Sergio", 1, true, 2.3, 30, "ciega de un ojo");
            pp1.Mascota = mascotita;
            Console.WriteLine(pp1);
        }
    }
}
