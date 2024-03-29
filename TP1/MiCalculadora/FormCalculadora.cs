﻿using System;
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
        /// <summary>
        /// Muestro en el lbl el resultado que obtengo al utulizar la funcion operar
        /// y muestro la informacion en el listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string test;
            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            if (cmbOperador.Text == "")
            {
                cmbOperador.Text = "+";
            }
            test = txtNumero1.Text + cmbOperador.Text + txtNumero2.Text + "=" + lblResultado.Text;
            lstOperaciones.Items.Add(test);
            cmbOperador.ResetText();
        }

        private void MiCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }


        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// limpio los lbl txtbox y listbox
        /// </summary>
        private void Limpiar()
        { 
            lblResultado.ResetText();
            cmbOperador.ResetText();
            txtNumero1.Clear();
            txtNumero2.Clear();
            lstOperaciones.Items.Clear();   
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado = 0;
            resultado=Calculadora.Operar(new Operando(numero1), new Operando(numero2), operador.FirstOrDefault());
            return resultado;

        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas salir del programa ?", "Cerrar Programa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }       
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);
        }

        private void btonConverADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text=Operando.BinarioDecimal(lblResultado.Text);   
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Deseas salir del programa ?", "Cerrar Programa", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
