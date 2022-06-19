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
    public partial class UserControlDays : UserControl
    {
        Medico medico;
        Cliente cliente;
        Calendario frmCalendario;
        public UserControlDays()
        {
            InitializeComponent();
        }
        public UserControlDays(Medico medico, Cliente cliente, Calendario calendario) : this()
        {
            this.medico = medico;
            this.cliente = cliente;
            this.frmCalendario = calendario;
        }


        public void days(int numday)
        {
            lbl_days.Text = numday.ToString();
        }


        private void UserControlDays_Click_1(object sender, EventArgs e)
        {
            int.TryParse(lbl_days.Text, out int diaEstatico);

            DateTime dt = new DateTime(Calendario.anioEstatico, Calendario.mesEstatico, diaEstatico);

            MenuAltaTurno menuAltaTurno = new MenuAltaTurno(medico, dt,cliente);
            if (menuAltaTurno.ShowDialog() == DialogResult.OK)
            {
                frmCalendario.Close();
            }
            
            
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
    }
}
