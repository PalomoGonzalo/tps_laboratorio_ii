using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Entidades
{
    [XmlInclude(typeof(Medico))]
    [XmlInclude(typeof(Operador))]
    public abstract class Personal
    {
        protected int id;
        protected string nombre;
        protected string password;

      

        public Personal() { }
        public Personal(int id, string nombre, string password):this()
        {
            this.id = id;
            this.nombre = nombre;
            this.password = password;
            
        }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Password { get => password; set => password = value; }

        public abstract Cliente verHistorialCliente(List<Cliente> listaClientes, int dniCliente);

       

    }
}
