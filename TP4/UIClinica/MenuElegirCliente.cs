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
    public partial class MenuElegirCliente : Form
    {

        bool flagCliente=false; 
        public MenuElegirCliente()
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

        private void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            dtvg_MedicosLista.Rows.Clear();
            if (!agregarAldataGridCliente(txt_dni.Text))
            {
                MessageBox.Show("Cliente no existe, dar de alta");
            }
            else
            {
                flagCliente = true;
            }
        }

        private bool agregarAldataGridCliente(string dniText)
        {
            foreach (var item in ManejadorDeDatos.ClienteList)
            {
                ManejadorDeDatos.PasarStringNumeros(dniText, out int dniInt);
                if (item.Dni == dniInt)
                {
                    int n = dtvg_MedicosLista.Rows.Add();
                    dtvg_MedicosLista.Rows[n].Cells[0].Value = item.Nombre;
                    dtvg_MedicosLista.Rows[n].Cells[1].Value = item.Dni.ToString();
                    dtvg_MedicosLista.Rows[n].Cells[2].Value = item.Edad.ToString();
                    return true;

                }
            }

            return false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (flagCliente == true)
            {
                MenuElegirMedicoParaAlta menuElegirMedicoParaAlta = new MenuElegirMedicoParaAlta();
                menuElegirMedicoParaAlta.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("ingrese un cliente valido");
            }
        }

        private void MenuElegirCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
