using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turnos
    {
        private int idMedico;
        private int hora;
        private DateTime fechaTurno;
        private int dniCliente;

        public Turnos(int idMedico, int hora, DateTime fechaTurno, int dniCliente)
        {
            this.idMedico = idMedico;
            this.hora = hora;
            this.fechaTurno = fechaTurno;
            this.dniCliente = dniCliente;
        }

        public int IdMedico { get => idMedico; set => idMedico = value; }
        public int Hora { get => hora; set => hora = value; }
        public DateTime FechaTurno { get => fechaTurno; set => fechaTurno = value; }
        public int DniCliente { get => dniCliente; set => dniCliente = value; }
    }
}
