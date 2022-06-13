using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class SqlConexion
    {

        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static SqlConexion()
        {
            connectionString = @"Data Source=.;Initial Catalog=TP4;Integrated Security=True";
            command = new SqlCommand();
            connection=new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;  
            command.Connection = connection;
        }

        public static void GuardarMedicos(Medico medico)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO MEDICO VALUES (@ID_MEDICO,@NOMBRE_MEDICO,@PASSWORD_MEDICO,@TIPO_MEDICO) ";
                command.Parameters.AddWithValue("@ID_MEDICO", medico.Id);
                command.Parameters.AddWithValue("@NOMBRE_MEDICO", medico.Nombre);
                command.Parameters.AddWithValue("@PASSWORD_MEDICO", medico.Password);
                command.Parameters.AddWithValue("@TIPO_MEDICO",medico.TipoMedico);

                int rows=command.ExecuteNonQuery();             
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo en la base de datos");
            }
            finally
            {
                connection.Close();
            }
        }

        public static void GuardarClientesASql(Cliente cliente)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO CLIENTES VALUES (@DNI,@NOMBRE,@EDAD)";
                command.Parameters.AddWithValue("@DNI", cliente.Dni);
                command.Parameters.AddWithValue("@NOMBRE", cliente.Nombre);
                command.Parameters.AddWithValue("@EDAD", cliente.Edad);
                

                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo en la base de datos");
            }
            finally
            {
                connection.Close();
            }
        }




        public static void CargarTurnosSql()
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM TURNOS";
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ManejadorDeDatos.TurnosList.Add(new Turnos(Convert.ToInt32(dataReader["NROTURNO"]), Convert.ToInt32(dataReader["IDMEDICO"]), Convert.ToInt32(dataReader["HORA"]), Convert.ToDateTime(dataReader["FECHA_TURNO"]), Convert.ToInt32(dataReader["DNI_CLIENTE"])));
                    }     
                }

            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo en la base de datos");
            }
            finally
            { 
                connection.Close();
            }
        }

        /// <summary>
        /// Elimino todo de la base de datos, ya que agrego el archivo xml serializado, para no sobrecargar la base de datos
        /// </summary>
        public static void EliminarTodoLosMedicos()
        {

            try
            {
                connection.Open();
                command.CommandText = $"DELETE FROM MEDICO";
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo en la base de datos");
            }
            finally
            {
                connection.Close();
            }
        }


        public static void EliminarTodoLosClientes()
        {

            try
            {
                connection.Open();
                command.CommandText = $"DELETE FROM CLIENTES";
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo en la base de datos");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
