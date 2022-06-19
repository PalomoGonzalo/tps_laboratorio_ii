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
    public partial class MenuOperador : Form
    {
        Operador operador;
        public MenuOperador()
        {
            InitializeComponent();
        }
        public MenuOperador(Operador op):this()
        {
            this.operador = op;
        }

        private void btn_AltaTurno_Click(object sender, EventArgs e)
        {
          MenuElegirCliente menuElegirCliente = new MenuElegirCliente();
            menuElegirCliente.ShowDialog();
        }

        private void MenuOperador_Load(object sender, EventArgs e)
        {
            label1.Text = operador.Nombre.ToUpper();
            esAdmin();
            
        }

        private void esAdmin()
        {
            if (operador.EsAdmin == true)
            {
                btn_darAltaCliente.Visible=true; 


            }

        }


        private void btn_darAltaCliente_Click(object sender, EventArgs e)
        {
            MenuAltaCliente menuAltaCliente = new MenuAltaCliente();
            menuAltaCliente.ShowDialog();
        }

        private void btn_cancelarTurno_Click(object sender, EventArgs e)
        {
            string legajoString = Interaction.InputBox("ingrese el dni del cliente para cancelar el turno");
            if (ManejadorDeDatos.PasarStringNumeros(legajoString, out int id))
            {
                Cliente miCliente = ManejadorDeDatos.CheckearLoginCliente(id);
                if (miCliente != null)
                {
                    CancelarTurno cancelarTurno = new CancelarTurno(miCliente,operador);
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
