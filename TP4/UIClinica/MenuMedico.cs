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
using Microsoft.VisualBasic;

namespace UIClinica
{
    public partial class MenuMedico : Form
    {
        CambiarInformacionDeInicio cambiarInfoMedico;
        
        Medico medico;
        public MenuMedico()
        {
            InitializeComponent();
        }
      

        public MenuMedico(Medico medico):this()
        {
            this.medico = medico;
            cambiarInfoMedico = CambiarLblMedico;

        }


        private void MenuMedico_Load(object sender, EventArgs e)
        {
            cambiarInfoMedico.Invoke();

        }


        public void CambiarLblMedico()
        {
            lbl_nombreMedico.Text = medico.Nombre;
        }

        private void btn_atender_Click(object sender, EventArgs e)
        {
            MenuAtenderCliente menuAtenderCliente = new MenuAtenderCliente(medico);  
            menuAtenderCliente.ShowDialog();

        }

        private void btn_listaEmpleados_Click(object sender, EventArgs e)
        {
            string legajoString = Interaction.InputBox("ingrese el dni del cliente para cancelar el turno");
            if (ManejadorDeDatos.PasarStringNumeros(legajoString, out int id))
            {
                Cliente miCliente = ManejadorDeDatos.CheckearLoginCliente(id);
                if (miCliente != null)
                {
                    CancelarTurno cancelarTurno = new CancelarTurno(miCliente, medico);
                    cancelarTurno.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error no existe ese dni");
                }



            }
        }
    }
}
