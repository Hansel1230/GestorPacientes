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
    

    public partial class Completarprueba : Form
    {
        public int id { get; set; }
        #region instancia
        public static Completarprueba Instancia { get; } = new Completarprueba();

        private GestorPacientesServices services;

        #endregion
        public Completarprueba()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            services = new GestorPacientesServices(connection);
        }

        private void Completarprueba_Load(object sender, EventArgs e)
        {
            TxtResultado.Text = "Ingrese Resultado";
        }
        private void TxtResultado_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text == "Ingrese Resultado")
            {
                TxtResultado.Text = "";

            }
        }

        private void TxtResultado_Leave(object sender, EventArgs e)
        {
            if (TxtResultado.Text =="")
            {
                TxtResultado.Text = "Ingrese Resultado";

            }
        }
        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text=="Ingrese Resultado")
            {
                MessageBox.Show("Debe ingresar un resultado");

            }
            else
            {
                try
                {
                    services.UpdateResultado(id, TxtResultado.Text);
                    Resultado_Laboratorio.Instancia.LoadData();
                }
                catch (Exception E)
                {
                    MessageBox.Show("Error");
                }
                MessageBox.Show(TxtResultado.Text,id.ToString());
                Resultado_Laboratorio.Instancia.Show();
                Instancia.Hide();
            }
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resultado_Laboratorio.Instancia.Show();
            Instancia.Hide();

        }
    }
}
