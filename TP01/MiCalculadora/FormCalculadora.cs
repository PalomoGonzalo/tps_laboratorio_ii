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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {


        public FormCalculadora()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();

            
            
            if (cmbOperador.Text == "")
            {
                cmbOperador.Text = "+";
            }
          
            string test = txtNumero1.Text + cmbOperador.Text + txtNumero2.Text + "=" + lblResultado.Text;
            lstOperaciones.Items.Add(test);
        }

        private void MiCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        { 
            lblResultado.ResetText();
            cmbOperador.ResetText();
            txtNumero1.Clear();
            txtNumero2.Clear();
        
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado = 0;
            resultado=Calculadora.Operar(new Operando(numero1), new Operando(numero2), operador.FirstOrDefault());

            return resultado;
            
        
        }

        private void lstOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
