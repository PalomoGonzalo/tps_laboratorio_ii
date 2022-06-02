using System;
using System.Collections.Generic;

namespace Entidades
{
    public abstract class Personal
    {
        protected int id;
        protected string nombre;
        protected string password;

        protected int Id { get => id; set => id = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Password { get => password; set => password = value; }

        protected Personal(int id, string nombre, string password)
        {
            this.id = id;
            this.nombre = nombre;
            this.password = password;
            
        }


        public abstract Cliente verHistorialCliente(List<Cliente> listaClientes, int dniCliente);



    }
}
