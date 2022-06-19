using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Entidades
{
  
    public class Medico : Personal
    {
        
        private string tipoMedico;


        public Medico()
        { 
        
        }
    

        public Medico(int id, string nombre, string password, string tipoMedico) : base(id, nombre, password)
        {
            this.TipoMedico = tipoMedico;

        }

        public string TipoMedico { get => tipoMedico; set => tipoMedico = value; }


        /// <summary>
        /// Atiendo el cliente y lo agrego a la lista de turnos atendidos
        /// </summary>
        /// <param name="nroTurno"></param>
        /// <returns></returns>
        public bool AtenderCliente(int nroTurno)
        {
            foreach (var item in ManejadorDeDatos.TurnosList)
            {
                if (nroTurno + item)
                {
                    ManejadorDeDatos.TurnosAtendidosList.Add(item);
                    ManejadorDeDatos.TurnosList.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public static bool operator +(int s1, Medico medico)
        {
            if (s1 == medico.Id)
            {
                return true;
            }
            return false;
        }






    }
}
