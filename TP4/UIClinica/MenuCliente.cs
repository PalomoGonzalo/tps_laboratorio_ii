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
            
        }

        private List<Turnos> ObtenerListaTurnosCliente()
        {
            
            List<Turnos> turnosAux = new List<Turnos>();

            foreach (var item in ManejadorDeDatos.TurnosList)
            {
                if (item.DniCliente == cliente.Dni)
                {
                    turnosAux.Add(item);
                }
            }
            return turnosAux;
        }


        private void CargarTurnosClienteAldata()
        {

            List<Turnos> turnos = ObtenerListaTurnosCliente();
            dtvg_clienteTurno.DataSource = turnos;
        }

        private void btn_cancelarTurno_Click(object sender, EventArgs e)
        {
            btn_cancelarTurno.Visible = false;
            dtvg_clienteTurno.Visible = true;
            btn_aceptarCancelar.Visible = true;
            dtvg_clienteTurno.Rows.Clear();
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
    }
}
