using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using Entidades;


namespace UIClinica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            ManejadorDeDatos.ClienteList = SerializadorGenerico<List<Cliente>>.LeerJson("JsonCliente");
            ManejadorDeDatos.PersonalList = SerializadorGenerico<List<Personal>>.LeerXml("XmlPersonal");
            SqlConexion.EliminarTodoLosMedicos();
            ManejadorDeDatos.TurnosList.Sort();
            Hilos.CargarHilos();

           
           
        }

        private void txt_legajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_autoLogMedico_Click(object sender, EventArgs e)
        {
            txt_legajo.Text = "1";
            txt_password.Text = "123";
        }

        private void btn_autoOperador_Click(object sender, EventArgs e)
        {
            txt_legajo.Text = "3";
            txt_password.Text = "123";
        }

        private void btn_loggear_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_legajo.Text, out int id))
            { 
                Medico miMedico=ManejadorDeDatos.checkearLoginMedico(this.txt_password.Text, id);
                Operador miOperador=ManejadorDeDatos.checkearLoginOperador(this.txt_password.Text, id);
                if (miOperador != null)
                {
                    MenuOperador frmMenuOperador = new MenuOperador(miOperador);
                    frmMenuOperador.ShowDialog();   
                   
                }
                else if (miMedico != null)
                {

                    MessageBox.Show($"{miMedico.Nombre}");
                }
                else
                {
                    MessageBox.Show("error de contraseña");
                }
            
            }
        }
    }
}
