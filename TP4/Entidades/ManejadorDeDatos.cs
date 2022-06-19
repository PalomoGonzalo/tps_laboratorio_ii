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
        static List<Turnos> turnosAtendidosList;

        static ManejadorDeDatos()
        {
            ClienteList = new List<Cliente>();
            PersonalList = new List<Personal>();
            TurnosList = new List<Turnos>();
            turnosAtendidosList = new List<Turnos>();
        }

        public static List<Cliente> ClienteList { get => clienteList; set => clienteList = value; }
        public static List<Personal> PersonalList { get => personalList; set => personalList = value; }
        public static List<Turnos> TurnosList { get => turnosList; set => turnosList = value; }
        public static List<Turnos> TurnosAtendidosList { get => turnosAtendidosList; set => turnosAtendidosList = value; }

        public static Medico CheckearLoginMedico(string password, int id)
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
        public static Operador CheckearLoginOperador(string password, int id)
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
        public static Cliente CheckearLoginCliente(int dni)
        {
            foreach (var item in clienteList)
            {
                if (item is Cliente cliente)
                {
                    if (cliente.Dni == dni)
                    {
                        return cliente;
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
        public static Medico BuscarPorIdMedico(int id)
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

        public static Cliente BuscarPorDniCliente(int dni)
        {
            foreach (var item in clienteList)
            {
                if (item is Cliente cliente)
                {
                    if (dni + cliente)
                    {
                        return cliente;

                    }
                }

            }
            return null;
        }
        public static void GuardarListaMedicoASql()
        {
            foreach (var item in ManejadorDeDatos.personalList)
            {
                if (item is Medico medico)
                { 
                
                    SqlConexion.GuardarMedicos(medico);
                }
            }
        
        
        }

        public static void GuardarListaClientesASql()
        {
            foreach (var item in ManejadorDeDatos.clienteList)
            {
                if (item is Cliente cliente)
                {

                    SqlConexion.GuardarClientesASql(cliente);
                }
            }


        }


        public static bool VerificarClienteExiste(int dni)
        {
            foreach (var item in ManejadorDeDatos.ClienteList)
            {
                if (item.Dni == dni)
                {
                    return true;
                }

            }

            return false;
        }
        public static int ObtenerUltimoTurno()
        {
            int ultimoTurno = 0;
            foreach (var item in ManejadorDeDatos.turnosList)
            {
                if (ultimoTurno <item.NroTurno)
                {
                    ultimoTurno = item.NroTurno;
                }
            }
            return ultimoTurno;
        }


    }
}
