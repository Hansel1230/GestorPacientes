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
    public partial class FomResultadosLPC : Form
    {

        public static FomResultadosLPC Instancia { get; } = new FomResultadosLPC();

        private GestorPacientesServices services;
        private int idCita = 0;

        public FomResultadosLPC()
        {
            InitializeComponent();
            
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            services = new GestorPacientesServices(connection);
        }

        public void LoadData(int idcita)
        {
            idCita = idcita;
            DgvResultLPC.DataSource = services.GetAllResultadoLPC(idcita);
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            services.CambiarEstadoCita(2, idCita);
            Instancia.Hide();
            Dgv.Instancia.LoadData();
            Dgv.Instancia.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            Dgv.Instancia.LoadData();
            Dgv.Instancia.Show();
        }
    }
}
