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

        event MostrarProximoTurno eventoProximoTurno;
        event CargarDatos eventoCargaDatosAlDataGrid;
        List<Turnos> turnos;
        Medico medico;
        Turnos turnoSiguiente;
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

            eventoCargaDatosAlDataGrid = CargarAlDataGrid;
            eventoCargaDatosAlDataGrid.Invoke();
            eventoProximoTurno.Invoke(turnoSiguiente);

        }
        /// <summary>
        /// cargo al data grid la lista filtrada de turnos
        /// </summary>
        private void CargarAlDataGrid()
        {
            dtvg_turnosLista.DataSource = null;
            turnos = obtenerListaTurnosMedico();
            dtvg_turnosLista.DataSource = turnos;
            turnoSiguiente=TurnoMasCercano(turnos);
            eventoProximoTurno = MostrarProximoTurnoPorMensaje;


        }

        private void MostrarProximoTurnoPorMensaje(Turnos turno)
        {
            MessageBox.Show($"El proximo turno a atender es el numero: {turno.NroTurno}");
        }

        private Turnos TurnoMasCercano(List<Turnos> turnosFiltrada)
        {
            Turnos turnoAux = null;
            DateTime dateTimeMinimo = DateTime.MaxValue;
            foreach (var item in turnosFiltrada)
            {
                if (dateTimeMinimo>item.FechaTurno)
                {
                    dateTimeMinimo = item.FechaTurno;
                    turnoAux = item;
                }  
            }
            return turnoAux;
        
        }


        /// <summary>
        /// Obtengo los turnos filtrado por el id medico y retorno esa lista
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Atiendo el cliente seleccionado en el data grid 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_atenderCliente_Click(object sender, EventArgs e)
        {
            if (dtvg_turnosLista.SelectedRows.Count>0)
            {
                Turnos turno = (Turnos)dtvg_turnosLista.CurrentRow.DataBoundItem;
                MessageBox.Show($"Se atendio el turno{turno.NroTurno}");
                medico.AtenderCliente(turno.NroTurno);              
            }
            else
            {
                MessageBox.Show("Seleccione un paciente");
            }

            eventoCargaDatosAlDataGrid.Invoke();
            turnoSiguiente = TurnoMasCercano(turnos);
            eventoProximoTurno.Invoke(turnoSiguiente);

        }
    }
}
