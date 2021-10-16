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
    public partial class FomCitaCompletada : Form
    {

        public static FomCitaCompletada Instancia { get; } = new FomCitaCompletada();

        private GestorPacientesServices services;
        private int idCita = 0;

        public FomCitaCompletada()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            services = new GestorPacientesServices(connection);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            Dgv.Instancia.LoadData();
            Dgv.Instancia.Show();
        }

        public void LoadData(int idcita)
        {
            idCita = idcita;
            DgvResultadoCC.DataSource = services.GetAllResultadoLPC(idcita);
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FomCitaCompletada_Load(object sender, EventArgs e)
        {

        }
    }
}
