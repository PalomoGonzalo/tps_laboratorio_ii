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
    public partial class MenuAtenderCliente : Form
    {
        Medico medico;
        public MenuAtenderCliente()
        {
            InitializeComponent();
        }
        public MenuAtenderCliente(Medico medico):this()
        {
           this.medico = medico;    
        }


        private void MenuAtenderCliente_Load(object sender, EventArgs e)
        {
            
            CargarAlDataGrid();
        }

        private void CargarAlDataGrid()
        {
            dtvg_turnosLista.DataSource = null;
            List<Turnos> turnos = obtenerListaTurnosMedico();
            dtvg_turnosLista.DataSource = turnos;
        }

        private List<Turnos> obtenerListaTurnosMedico()
        {
            dtvg_turnosLista.Rows.Clear();
            List<Turnos> turnosAux=new List<Turnos>();
           
            foreach (var item in ManejadorDeDatos.TurnosList)
            {
                if (item.IdMedico == medico.Id)
                {
                    turnosAux.Add(item);
                }
            }
            return turnosAux;         
        }

        private void btn_atenderCliente_Click(object sender, EventArgs e)
        {
            if (dtvg_turnosLista.SelectedRows.Count>0)
            {
                Turnos turno = (Turnos)dtvg_turnosLista.CurrentRow.DataBoundItem;
                MessageBox.Show($"Se atendio el turno{turno.NroTurno}");
                medico.DarBajaTurno(turno.NroTurno);
                
            }
            else
            {
                MessageBox.Show("Seleccion un paciente");
            }
            CargarAlDataGrid();


        }
    }
}
