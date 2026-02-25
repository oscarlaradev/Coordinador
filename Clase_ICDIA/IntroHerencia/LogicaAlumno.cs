using System;
namespace IntroHerencia;

public class LogicaAlumno
{
    public LogicaAlumno()
    {
        Persona pLuis;
        //pLuis = new Persona("Luis");
        pLuis = new Alumno("Luis");

        pLuis.Saludar();
    }
}