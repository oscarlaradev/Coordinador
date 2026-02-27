using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_definicion
{
    public class Gato
    {

        //modificadores de acceso 
        // private / public
        private int id_gato;
        string nombre;
        public string color;
        private int edad;
        private bool estaVacunado;
        private double peso;

        public string Nombre() {
            return nombre;         
        }

        public void Nombre(string nombre) {
            this.nombre = nombre;
        }
    }
}