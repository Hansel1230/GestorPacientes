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
    public partial class MenuHome : Form
    {
        #region instancia
        public static MenuHome Instancia { get; } = new MenuHome();
        #endregion

        private GestorPacientesServices services;
        public string TipoMant { get; set; } = "";
        public int HomeValid { get; set; }

        public MenuHome()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            services = new GestorPacientesServices(connection);
        }

        #region Eventos 

        private void MenuHome_Load(object sender, EventArgs e)
        {

        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            if (HomeValid == 1)
            {
                TipoMant = "Usuario";
                Dgv.Instancia.LoadData();
                Dgv.Instancia.Show();
                Instancia.Hide();              
            }
            else
            {
                MessageBox.Show("Usted no tiene acceso a ese apartado");
            }
            
        }

        private void BtnMedico_Click(object sender, EventArgs e)
        {
            if (HomeValid == 1)
            {
                TipoMant = "Medico";
                Dgv.Instancia.LoadData();
                Dgv.Instancia.Show();
                Instancia.Hide();
                
            }
            else
            {
                MessageBox.Show("Usted no tiene acceso a ese apartado");
            }
            
        }

        private void BtnPrLabo_Click(object sender, EventArgs e)
        {
            if (HomeValid == 1)
            {
                TipoMant = "PrLabo";
                Dgv.Instancia.LoadData();
                Dgv.Instancia.Show();
                Instancia.Hide();                
            }
            else
            {
                MessageBox.Show("Usted no tiene acceso a ese apartado");
            }
            
        }

        private void BtnPaciente_Click(object sender, EventArgs e)
        {
            if (HomeValid == 0)
            {
                TipoMant = "Paciente";
                Dgv.Instancia.LoadData();
                Dgv.Instancia.Show();
                Instancia.Hide();                
            }
            else
            {
                MessageBox.Show("Usted no tiene acceso a ese apartado");
            }
            
        }

        private void BtnCita_Click(object sender, EventArgs e)
        {
            if (HomeValid == 0)
            {
                Dgv.Instancia.Show();
                Instancia.Hide();
                TipoMant = "Cita";
            }
            else
            {
                MessageBox.Show("Usted no tiene acceso a ese apartado");
            }
             
        }

        private void BtnResulPrLabo_Click(object sender, EventArgs e)
        {
            if (HomeValid == 0)
            {
                Dgv.Instancia.Show();
                Instancia.Hide();
                TipoMant = "ResulPrLabo";
            }
            else
            {
                MessageBox.Show("Usted no tiene acceso a ese apartado");
            }
            
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.Instancia.Show();
            Instancia.Hide();
           
        }

        #endregion
    }
}
