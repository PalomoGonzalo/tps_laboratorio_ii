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


        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Dni: {dni}");
            sb.AppendLine($"Nombre:{ nombre} ");
            sb.AppendLine($"Edad: {edad}");
            return sb.ToString();


        }
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

        



    }
}
