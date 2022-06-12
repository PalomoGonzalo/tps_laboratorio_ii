﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class Hilos
    {

        public static async void CargarHilos()
        {
            Task task = new Task(SqlConexion.CargarTurnosSql);
            try
            {
                task.Start();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            await task;

            Task task2 = new Task(ManejadorDeDatos.CargarListaMedicoASql);
            try
            {

                task2.Start();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}