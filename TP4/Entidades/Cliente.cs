using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : iDarBajaTurno
    {
        private int dni;
        private string nombre;
        private int edad;

        public Cliente()
        {

        }

        public Cliente(int dni, string nombre, int edad) : this()
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Edad = edad;
        }
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }



        public static bool operator +(int s1, Cliente cliente)
        {
            if (s1 == cliente.dni)
            {
                return true;
            }
            return false;
        }

        public bool DarBajaTurno(int nroTurno)
        {
            foreach (var item in ManejadorDeDatos.TurnosList)
            {
                if (nroTurno + item)
                {
                    ManejadorDeDatos.TurnosList.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public List<Turnos> VerHistorialClienteTurnos(List<Turnos> turnos, int dniCliente)
        {
            List<Turnos> turnoFiltro = new List<Turnos>();
            foreach (var item in turnos)
            {
                if (dniCliente ==item.DniCliente)
                {
                    turnoFiltro.Add(item);
                }
            }
            return turnoFiltro;

        }





    }
}
