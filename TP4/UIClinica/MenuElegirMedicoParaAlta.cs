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
    public partial class MenuElegirMedicoParaAlta : Form
    {
        Medico medico;
        
        public MenuElegirMedicoParaAlta()
        {
            InitializeComponent();
        }



        private void btn_buscarMedico_Click(object sender, EventArgs e)
        {
            if (cmb_TipoMedico.SelectedIndex != -1)
            {
                agregarAldataGridMedicos(cmb_TipoMedico.SelectedItem.ToString());

            }
        }

        private void agregarAldataGridMedicos(string tipoMedico)
        {
            foreach (var item in ManejadorDeDatos.PersonalList)
            {
                if (item is Medico medico)
                {
                    if (medico.TipoMedico == tipoMedico)
                    {
                        int n = dtvg_MedicosLista.Rows.Add();
                        dtvg_MedicosLista.Rows[n].Cells[0].Value = medico.Nombre;
                        dtvg_MedicosLista.Rows[n].Cells[1].Value = medico.Id.ToString();
                        dtvg_MedicosLista.Rows[n].Cells[2].Value = medico.TipoMedico;

                    }

                }

            }


        }

        private void MenuElegirMedicoParaAlta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string legajoString = Interaction.InputBox("ingrese el legajo del medico para verificar el calendario");
            if (ManejadorDeDatos.PasarStringNumeros(legajoString, out int id))
            {
                medico = ManejadorDeDatos.buscarPorIdMedico(id);

                if (medico != null)
                {
                    if (medico.TipoMedico == cmb_TipoMedico.SelectedItem.ToString())
                    {
                        Calendario frmCalendario = new Calendario(medico);
                        frmCalendario.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error ingrese id del medico que corresponde a la especialidad seleccionada");
                    }
                }
                else
                {
                    MessageBox.Show("Error ingrese datos correcto");
                }


            }


        }
    }
}
