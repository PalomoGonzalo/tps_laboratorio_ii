using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operador : Personal
    {
        protected bool esAdmin;
        public Operador(int id, string nombre, string password, bool esAdmin) : base(id, nombre, password)
        {
            this.EsAdmin = esAdmin;
        }

        protected bool EsAdmin { get => esAdmin; set => esAdmin = value; }

        public override Cliente verHistorialCliente(List<Cliente> listaClientes, int dniCliente)
        {
            throw new NotImplementedException();
        }
    }
}
