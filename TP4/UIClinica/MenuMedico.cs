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
    public partial class MenuMedico : Form
    {
        Medico medico;
        public MenuMedico()
        {
            InitializeComponent();
        }
      

        public MenuMedico(Medico medico):this()
        {
            this.medico = medico;
        }


        private void MenuMedico_Load(object sender, EventArgs e)
        {
            lbl_nombreMedico.Text = medico.Nombre;

        }

        private void btn_atender_Click(object sender, EventArgs e)
        {
            MenuAtenderCliente menuAtenderCliente = new MenuAtenderCliente(medico);  
            menuAtenderCliente.ShowDialog();

        }

        private void lbl_nombreMedico_Click(object sender, EventArgs e)
        {

        }
    }
}
