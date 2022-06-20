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
            SqlConexion.EliminarTodoLosClientes();
            
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
                Medico miMedico=ManejadorDeDatos.CheckearLoginMedico(this.txt_password.Text, id);
                Operador miOperador=ManejadorDeDatos.CheckearLoginOperador(this.txt_password.Text, id);
                Cliente miCliente = ManejadorDeDatos.CheckearLoginCliente(id);
                if (miOperador != null)
                {
                    MenuOperador frmMenuOperador = new MenuOperador(miOperador);
                    frmMenuOperador.ShowDialog();   
                   
                }
                else if (miMedico != null)
                {

                    MenuMedico medico = new MenuMedico(miMedico);
                    medico.ShowDialog();
                }
                else if (miCliente != null)
                {
                    MenuCliente cliente = new MenuCliente(miCliente); 
                    cliente.ShowDialog();   
                   
                }
                else
                {
                    MessageBox.Show("error de contraseña");
                }
            
            }
        }

        private void btn_clienteLog_Click(object sender, EventArgs e)
        {
            txt_legajo.Text = "1";
            txt_password.Text = "";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
