using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipoMedico
    {
        Cardiologo,
        Clinico,
        Neurologo,
    }

    public class Medico : Personal
    {
       private ETipoMedico tipoMedico;


        
        public Medico(int id, string nombre, string password, ETipoMedico tipoMedico) : base(id, nombre, password)
        {
            this.TipoMedico = tipoMedico;
        }

        public ETipoMedico TipoMedico { get => tipoMedico; set => tipoMedico = value; }

        public override Cliente verHistorialCliente(List<Cliente> listaClientes, int dniCliente)
        {
            throw new NotImplementedException();
        }
    }
}
