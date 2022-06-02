using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ManejadorDeDatos
    {
        static List<Cliente> clienteList;

        static ManejadorDeDatos()
        { 
            ClienteList=new List<Cliente>();
            ManejadorDeDatos.ClienteList.Add(new Cliente(122, "Matias", 2, true));

        }

        public static List<Cliente> ClienteList { get => clienteList; set => clienteList = value; }
    }
}
