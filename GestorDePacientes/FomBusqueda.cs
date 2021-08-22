using BusinesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDePacientes
{
    public partial class FomBusqueda : Form
    {

        public static FomBusqueda Instancia { get; } = new FomBusqueda();

        private GestorPacientesServices services;
        private string tipo = "paciente";
        public int pacienteId = 0;
        public int MedicoId = 0;
        public string nombrePaciente = "";
        public string nombreMedico = "";
        public DataGridViewRow Filaceleccionada = null;

        public FomBusqueda()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            services = new GestorPacientesServices(connection);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadData()
        {
            if (tipo == "paciente")
            {
                lbltipo.Text = "Seleccione Paciente";
                DgvPacientes.DataSource = services.GetAllAviablePacientes();
            }
            else
            {
                lbltipo.Text = "Seleccione Medico";
                DgvPacientes.DataSource = services.GetAllAviableMedicos();
            }
            
        }
        public void LoadDataByCedula(string cedula)
        {
            if (tipo == "paciente")
            {
                DgvPacientes.DataSource = services.GetAllAviablePacientesByCedula(cedula);
            }
            else
            {
                DgvPacientes.DataSource = services.GetAllAviableMedicosByCedula(cedula);
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            string cedula = TxtFiltrar.Text;

            if (cedula=="")
            {
                MessageBox.Show("Debe ingresar una cedula valida para realizar la busqueda", "Advertencia");
            }
            else
            {
                bool isValidCedula = false;

                if (tipo == "paciente")
                {
                    isValidCedula = services.IsValidCedulaPaciente(cedula);
                }
                else
                {
                    isValidCedula = services.IsValidCedulaMedico(cedula);
                }
                

                if (isValidCedula)
                {
                    LoadDataByCedula(cedula);
                }
                else
                {
                    MessageBox.Show("Debe ingresar una cedula valida para realizar la busqueda", "Advertencia");
                }
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            string nombre = Filaceleccionada.Cells[1].Value.ToString();
            int id = Convert.ToInt32(Filaceleccionada.Cells[3].Value.ToString());

            if (tipo == "paciente")
            {
                nombrePaciente = nombre;
                pacienteId = id;
                tipo = "medico";
                TxtFiltrar.Text = "";
                Instancia.Hide();
                LoadData();
                Instancia.Show();
            }
            else
            {
                nombreMedico = nombre;
                MedicoId = id;
                formularioCita.Instancia.LoadData();
                Instancia.Hide();
                formularioCita.Instancia.Show();
            }
        }

        private void DgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BtnSiguiente.Visible = true;
                Filaceleccionada = DgvPacientes.Rows[e.RowIndex];
            }
        }
    }
}
