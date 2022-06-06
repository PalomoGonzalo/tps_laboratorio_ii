using System;
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
        public MenuAltaTurno()
        {
            InitializeComponent();
        }
        public MenuAltaTurno(Medico medico,DateTime time):this()
        {
            this.time = time;
            this.medico = medico;
        }

        private void MenuAltaTurno_Load(object sender, EventArgs e)
        {
            cargarBoton();
            cargarEstadoHorarioDisponible();
        }

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
                    
                    }
                }


            }


        }
        private void EventoBotonGeneral_Click(object sender, EventArgs e)
        {
            var control = sender as Button;
            string descripcionBoton = control.Text;
          
            //if (int.TryParse(descripcionBoton, out int codigoMesa))
            //{

            //    if (control.Tag.ToString() == "Libre")
            //    {

                  
            //    }
               
            //}
            //cargarEstadoMesa();
        }

        private Boolean ExisteHoraraCargada(string butonNombre)
        {
            foreach (var item in ManejadorDeDatos.TurnosList)
            {
                if(item.IdMedico==medico.Id)
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
