using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace UIClinica
{
    public partial class Calendario : Form
    {
        public static int mesEstatico;
        public static int anioEstatico;
        int mes;
        int anio;
        
        Medico medico;
        public Calendario()
        {
            InitializeComponent();
        }

        public Calendario(Medico medico) : this()
        {
            this.medico = medico;
            
        }
        private void Calendario_Load(object sender, EventArgs e)
        {
            CargarDias();
            lbl_nombreMedico.Text = medico.Nombre.ToUpper();
            lbl_especialidadMedico.Text=medico.TipoMedico.ToUpper();
            
        }
        /// <summary>
        /// Genero los dias de hoy, guardando en la variable mes y anio, y convierto los dias que no se usa en el mes y lo guardo en la variable
        /// DiasPorsemanas, recorro con un for esos dias y agrego un control blanco.
        /// Days= guarda la cantidad de dias de el mes actual, se lo recorre un form y se le agrega un controluser con un label con el numero de dia
        /// </summary>
        private void CargarDias()
        {
            DateTime now = DateTime.Now;
            mes = now.Month;
            anio = now.Year;
            DateTime inicioDeMes = new DateTime(anio, mes, 1);
            int days = DateTime.DaysInMonth(anio, mes);
            mesEstatico = mes;
            anioEstatico = anio;
            string nombreFecha = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToUpper();
            lbl_fecha.Text = nombreFecha;
            int diasPorSemanas = Convert.ToInt32(inicioDeMes.DayOfWeek.ToString("d"));
            
            for (int i = 0; i < diasPorSemanas; i++)
            {
                UserControlBlank us = new UserControlBlank();
                PanelControl.Controls.Add(us);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(medico);
                ucdays.days(i);
                PanelControl.Controls.Add(ucdays);
            }
        }
        private void CargarDias(int mes)
        {
            PanelControl.Controls.Clear();
            DateTime inicioDeMes = new DateTime(anio, mes, 1);
            int days = DateTime.DaysInMonth(anio, mes);
            string nombreFecha = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToUpper();
            mesEstatico = mes;
            anioEstatico = anio;
            lbl_fecha.Text = nombreFecha;
            int diasPorSemanas = Convert.ToInt32(inicioDeMes.DayOfWeek.ToString("D"));

            for (int i = 0; i < diasPorSemanas; i++)
            {
                UserControlBlank us = new UserControlBlank();
                PanelControl.Controls.Add(us);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(medico);
                ucdays.days(i);
                PanelControl.Controls.Add(ucdays);
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            mes++;
            CargarDias(mes);
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            mes--;
            CargarDias(mes);
        }
    }
}
