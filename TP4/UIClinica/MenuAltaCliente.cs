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
    public partial class MenuAltaCliente : Form
    {
        public MenuAltaCliente()
        {
            InitializeComponent();
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_nombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Doy de alta el cliente con la informacion ingresada, verificando si no hay caracteres vacio
        /// si la edad es mayor de 0 
        /// Cuando esta todo okey agrega el cliente nuevo a la lista y lo cargo en la base de datos de sql con un hilo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_altaCliente_Click(object sender, EventArgs e)
        {
            ManejadorDeDatos.PasarStringNumeros(txt_dni.Text, out int dni);
            ManejadorDeDatos.PasarStringNumeros(textBox2.Text, out int edad);
            if (!(string.IsNullOrEmpty(txt_dni.Text) || (string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(txt_nombreCliente.Text)))))
            {
                if (edad > 0)
                {
                    if (!ManejadorDeDatos.VerificarClienteExiste(dni))
                    {
                        Cliente clienteNuevo = new Cliente(dni, txt_nombreCliente.Text, edad);
                        ManejadorDeDatos.ClienteList.Add(clienteNuevo);
                        Hilos.GuardarClientes(clienteNuevo);
                        MessageBox.Show("Se cargo correctamente el cliente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error este cliente ya existe");
                    }
                }
                else
                {
                    MessageBox.Show("Error, ingrese una edad correcta");
                }
                    
            }
            else
            {
                MessageBox.Show("Complete todos los datos");
            }
        }
    }
}
