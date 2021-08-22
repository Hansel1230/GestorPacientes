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
    public partial class fomPruebasCreadas : Form
    {
        public static fomPruebasCreadas Instancia { get; } = new fomPruebasCreadas();

        private GestorPacientesServices services;
        private int idCita = 0;

        public fomPruebasCreadas()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            services = new GestorPacientesServices(connection);
        }

        public void visibleButton()
        {
            btnRealizar.Visible = false;
        }

        public void LoadData(int cita)
        {
            idCita = cita;
            visibleButton();
            DgvPruebasCreadas.MultiSelect = true;
            DgvPruebasCreadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPruebasCreadas.DataSource = services.GetAllPrueba();
        }

        private void DgvPruebasCreadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnRealizar.Visible = true;
            }
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            int idPaciente = Convert.ToInt32(services.GetIdPacienteCita(idCita));
            int idMedico = Convert.ToInt32(services.GetIdMedicoCita(idCita));


            DataBase.Modelos.ResultPruebaLaboratorio resultPruebaLaboratorio = null;

            foreach (DataGridViewRow row in DgvPruebasCreadas.SelectedRows)
            {
                int idPruebaLaboratorio = Convert.ToInt32(row.Cells[0].Value);

                resultPruebaLaboratorio = new DataBase.Modelos.ResultPruebaLaboratorio(
                   idPaciente, idCita, idPruebaLaboratorio, idMedico, "", 0);

                services.AgregarResultadoLaboratorio(resultPruebaLaboratorio);
            }

            services.CambiarEstadoCita(1, idCita);
            Dgv.Instancia.LoadData();
            Dgv.Instancia.Show();
            Instancia.Hide();
        }
    }


}
