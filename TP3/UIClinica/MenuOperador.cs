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
          

            MenuElegirMedicoParaAlta menuElegirMedicoParaAlta = new MenuElegirMedicoParaAlta(operador);
            menuElegirMedicoParaAlta.ShowDialog();
        }

        private void MenuOperador_Load(object sender, EventArgs e)
        {

        }
    }
}
