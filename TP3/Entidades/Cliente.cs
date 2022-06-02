using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int dni;
        private string nombre;
        private int edad;
        private bool tieneObraSocial;

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public bool TieneObraSocial { get => tieneObraSocial; set => tieneObraSocial = value; }

        public Cliente()
        { 
        
        }


        public Cliente(int dni, string nombre, int edad, bool tieneObraSocial):this()
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Edad = edad;
            this.TieneObraSocial = tieneObraSocial;
        }




    }
}
