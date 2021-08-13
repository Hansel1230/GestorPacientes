using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BusinesLayer;

namespace GestorDePacientes
{
    public partial class Dgv : Form
    {
        #region instancia
        public static Dgv Instancia { get; } = new Dgv();
        #endregion

        private GestorPacientesServices services;

        public Dgv()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            services = new GestorPacientesServices(connection);

        }

        #region Eventos 

        private void Dgv_Load(object sender, EventArgs e)
        {
            deselect();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuHome.Instancia.Show();
            Instancia.Hide();
        }
        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            validAdd();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            validAdd();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            deselect();
        }
        #endregion

        #region Metodos

        public void deselect()
        {
            BtnEditar.Visible = false;
            BtnEliminar.Visible = false;
            BtnDeselect.Visible = false;
        }

        public void validAdd()
        {
            if (MenuHome.Instancia.TipoMant == "Usuario")
            {
                MantUsuario.Instancia.Show();
                Instancia.Hide();

            }else if (MenuHome.Instancia.TipoMant == "Medico")
            {
                MAntMedico.Instancia.Show();
                Instancia.Hide();
            }
            else if (MenuHome.Instancia.TipoMant == "PrLabo")
            {
                MantPrueva.Instancia.Show();
                Instancia.Hide();
            }
            else if (MenuHome.Instancia.TipoMant == "Paciente")
            {
                MantPAcientes.Instancia.Show();
                Instancia.Hide();
            }
            else if (MenuHome.Instancia.TipoMant == "Cita")
            {
                //MantCita.Instancia.Show();
                Instancia.Hide();
            }
            else if (MenuHome.Instancia.TipoMant == "ResulPrLabo")
            {
                //ResultPruevaLabo.Instancia.Show();
                Instancia.Hide();
            }
        }
               

        #endregion        
    }
}
