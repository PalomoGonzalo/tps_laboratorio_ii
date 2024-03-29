﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UIClinica
{
    public partial class MenuAltaTurno : Form
    {
        Medico medico;
        DateTime time;
        Cliente cliente;
        public MenuAltaTurno()
        {
            InitializeComponent();
        }
        public MenuAltaTurno(Medico medico, DateTime time, Cliente cliente) : this()
        {
            this.time = time;
            this.medico = medico;
            this.cliente = cliente;
        }

        private void MenuAltaTurno_Load(object sender, EventArgs e)
        {
            cargarBoton();
            cargarEstadoHorarioDisponible();
            lbl_especialidad.Text = medico.TipoMedico;
            lbl_fecha.Text = time.ToShortDateString();
            lbl_nombreMedico.Text = medico.Nombre;
        }
        /// <summary>
        /// sobrecargo el evento click de los botones con la funcion eventobotongeneral_click
        /// </summary>
        private void cargarBoton()
        {
            button1.Click += EventoBotonGeneral_Click;
            button2.Click += EventoBotonGeneral_Click;
            button3.Click += EventoBotonGeneral_Click;
            button4.Click += EventoBotonGeneral_Click;
            button5.Click += EventoBotonGeneral_Click;
            button6.Click += EventoBotonGeneral_Click;
            button7.Click += EventoBotonGeneral_Click;
            button8.Click += EventoBotonGeneral_Click;
            button9.Click += EventoBotonGeneral_Click;
        }
        /// <summary>
        /// Con la funcion ExisteHoraCargada si devuelve true pinto el bonton en rojo y lo desactivo
        /// </summary>
        public void cargarEstadoHorarioDisponible()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    Button boton = (Button)c;

                    if (ExisteHoraraCargada(boton.Text))
                    {
                        boton.Enabled = false;
                        boton.BackColor = Color.Red;

                    }
                }
            }
        }

        /// <summary>
        /// Agrego los botones.click que utilizo para las horas a un evento general 
        /// Y Creo un nuevo turno, obtieniendo automaticamente el nro de turno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventoBotonGeneral_Click(object sender, EventArgs e)
        {
            var control = sender as Button;
            string descripcionBoton = control.Text;
            ManejadorDeDatos.PasarStringNumeros(descripcionBoton, out int hora);
            int nroTurno = ManejadorDeDatos.ObtenerUltimoTurno() + 1;


            Turnos turnoNuevo = new Turnos(nroTurno,medico.Id,hora,time,cliente.Dni);
            ManejadorDeDatos.TurnosList.Add(turnoNuevo);
            MessageBox.Show($"Se dio de alta correctamente el turno {turnoNuevo.NroTurno}");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        /// <summary>
        /// Verifica en la lista de turnos, filtrando el id del medico, la fecha de turno
        /// y la hora que se relaciona con el boton.text que tiene.
        /// </summary>
        /// <param name="butonNombre"></param>
        /// <returns></returns>
        private Boolean ExisteHoraraCargada(string butonNombre)
        {
            foreach (var item in ManejadorDeDatos.TurnosList)
            {
                if (item.IdMedico == medico.Id)
                {
                    if (item.FechaTurno == time)
                    {
                        if (item.Hora.ToString() == butonNombre)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

    }
}
