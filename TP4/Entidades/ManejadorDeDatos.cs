using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class ManejadorDeDatos
    {
        static List<Cliente> clienteList;

        static List<Personal> personalList;
        static List<Turnos> turnosList;

        static ManejadorDeDatos()
        {
            ClienteList = new List<Cliente>();
            PersonalList = new List<Personal>();
            TurnosList = new List<Turnos>();

            //turnosList.Add(new Turnos(1,1, 9,new DateTime(2022,06,06), 1));
        }

        public static List<Cliente> ClienteList { get => clienteList; set => clienteList = value; }
        public static List<Personal> PersonalList { get => personalList; set => personalList = value; }
        public static List<Turnos> TurnosList { get => turnosList; set => turnosList = value; }

        public static Medico checkearLoginMedico(string password, int id)
        {
            foreach (var item in personalList)
            {
                if (item is Medico medico)
                {
                    if (medico.Password == password && medico.Id == id)
                    {
                        return medico;

                    }
                }

            }

            return null;
        }
        public static Operador checkearLoginOperador(string password, int id)
        {
            foreach (var item in personalList)
            {
                if (item is Operador operador)
                {
                    if (operador.Password == password && operador.Id == id)
                    {
                        return operador;

                    }
                }

            }

            return null;
        }

        public static bool PasarStringNumeros(string cadena, out int retorno)
        {
            if (int.TryParse(cadena, out retorno))
            {
                return true;
            }

            else
            {
                return false;
            }

        }
        public static Medico buscarPorIdMedico(int id)
        {
            foreach (var item in personalList)
            {
                if (item is Medico medico)
                {
                    if (id+medico)
                    {
                        return medico;

                    }
                }

            }
            return null;
        }
        public static void CargarListaMedicoASql()
        {
            foreach (var item in ManejadorDeDatos.personalList)
            {
                if (item is Medico medico)
                { 
                
                    SqlConexion.GuardarMedicos(medico);
                }
            }
        
        
        }


    }
}
