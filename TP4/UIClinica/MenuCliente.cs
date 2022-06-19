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
    public partial class MenuCliente : Form
    {
        Cliente cliente;
        public MenuCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente; 
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {
            dtvg_clienteTurno.Visible = false;
            btn_aceptarCancelar.Visible = false;
            lbl_nombreCliente.Text = cliente.Nombre.ToUpper();   
        }


        private void CargarTurnosClienteAldata()
        {       
            dtvg_clienteTurno.DataSource = cliente.VerHistorialClienteTurnos(ManejadorDeDatos.TurnosList, cliente.Dni);
        }

        private void btn_cancelarTurno_Click(object sender, EventArgs e)
        {
            dtvg_clienteTurno.Visible = true;
            btn_aceptarCancelar.Visible = true;
            CargarTurnosClienteAldata();
        }

        private void btn_aceptarCancelar_Click(object sender, EventArgs e)
        {
            if (dtvg_clienteTurno.SelectedRows.Count > 0)
            {
                Turnos turno = (Turnos)dtvg_clienteTurno.CurrentRow.DataBoundItem;
                MessageBox.Show($"Se elimino el turno{turno.NroTurno}");
                cliente.DarBajaTurno(turno.NroTurno);
                CargarTurnosClienteAldata();

            }
            else
            {
                MessageBox.Show("Seleccione un turno");
            }
        }

        private void btn_historialTurnos_Click(object sender, EventArgs e)
        {
            btn_aceptarCancelar.Visible=false;
            dtvg_clienteTurno.Visible=true;
            dtvg_clienteTurno.DataSource = cliente.VerHistorialClienteTurnos(ManejadorDeDatos.TurnosList, cliente.Dni);
        }
    }
}
