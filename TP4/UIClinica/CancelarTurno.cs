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
    public partial class CancelarTurno : Form
    {
        Cliente cliente;
        Personal personal;
        public CancelarTurno(Cliente cliente, Personal personal)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.personal = personal;
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



        private void CancelarTurno_Load(object sender, EventArgs e)
        {
            CargarTurnosClienteAldata();
            lbl_nombreCliente.Text = cliente.Nombre.ToUpper();
        }

        private void btn_aceptarCancelar_Click(object sender, EventArgs e)
        {
            if (dtvg_clienteTurno.SelectedRows.Count > 0)
            {
                Turnos turno = (Turnos)dtvg_clienteTurno.CurrentRow.DataBoundItem;
                MessageBox.Show($"Se elimino el turno{turno.NroTurno}");
                personal.DarBajaTurno(turno.NroTurno);
                CargarTurnosClienteAldata();

            }
            else
            {
                MessageBox.Show("Seleccione un turno");
            }
        }
    }
}
