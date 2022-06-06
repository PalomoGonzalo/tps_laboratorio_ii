using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public enum Eturnos 
    {
        Ocho=8,
        Nueve=9,
        Diez=10,
        Once=11,
        Doce=12,
        Trece=13,
        Catorce=14,
        Quince=15,
        Diecises=16,
    }
    public class Turnos
    {
        private int idMedico;
        private int hora;
        private DateTime fechaTurno;
        private int dniCliente;
        private int nroTurno;
        static int nroTurnoStatico;


        static Turnos()
        {
            nroTurnoStatico = 10000;
        }
        public Turnos(int idMedico, int hora, DateTime fechaTurno, int dniCliente)
        {
            this.nroTurno=nroTurnoStatico;
            nroTurnoStatico++;
            this.idMedico = idMedico;
            this.Hora = hora;
            this.fechaTurno = fechaTurno;
            this.dniCliente = dniCliente;
        }

        public int IdMedico { get => idMedico; set => idMedico = value; }
       
        public DateTime FechaTurno { get => fechaTurno; set => fechaTurno = value; }
        public int DniCliente { get => dniCliente; set => dniCliente = value; }
        public int Hora { get => hora; set => hora = value; }
    }
}
