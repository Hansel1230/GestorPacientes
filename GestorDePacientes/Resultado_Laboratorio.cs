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
    public partial class Resultado_Laboratorio : Form
    {
        #region instancia
        public static Resultado_Laboratorio Instancia { get; } = new Resultado_Laboratorio();

        private GestorPacientesServices services;

        #endregion

        #region props
        public bool isValid { get; set; }

        private int index = 0;

        public DataGridViewRow Filaceleccionada = null;
        #endregion

        public Resultado_Laboratorio()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            services = new GestorPacientesServices(connection);

            isValid = true;
        }

        #region Eventos
        private void Resultado_Laboratorio_Load(object sender, EventArgs e)
        {
            TxtFiltrar.Text = "Ingrese Cedula";
        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            
            if (TxtFiltrar.Text== "Ingrese Cedula")
            {
                MessageBox.Show("Primero Ingrese una cedula","Info");
            }                       
        }
        private void BtnReportar_Click(object sender, EventArgs e)
        {
            
        }
        private void DgvResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Filaceleccionada = DgvResultados.Rows[e.RowIndex];
            index = Convert.ToInt32(Filaceleccionada.Cells[0].Value.ToString());
            BtnReportar.Visible = true;
            BtnDeselect.Visible = true;
            Completarprueba.Instancia.id = index;
        }
        private void TxtFiltrar_Click(object sender, EventArgs e)
        {
            if (TxtFiltrar.Text == "Ingrese Cedula")
            {
                TxtFiltrar.Text = "";
            }
        }
        private void TxtFiltrar_Leave(object sender, EventArgs e)
        {
            if (TxtFiltrar.Text == "")
            {
                TxtFiltrar.Text = "Ingrese Cedula";
            }
        }
        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuHome.Instancia.Show();
            Instancia.Hide();
        }

        private void BtnReportar_Click_1(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Primero debe seleccionar!!");
            }
            else
            {                
                Completarprueba.Instancia.Show();
                Instancia.Hide();
                deselect();
            }                       
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            deselect();
        }
        #endregion

        #region Metodos
        public void LoadData()
        {
            DgvResultados.DataSource = services.GetAllResultado();
        }

        public void deselect()
        {
            Filaceleccionada = null;
            //BtnFiltrar.Visible = false;   
            BtnDeselect.Visible = false;
            BtnReportar.Visible = false;
            DgvResultados.ClearSelection();
            index = 0;
        }
        #endregion

        public void LoadDataByCedula(string cedula)
        {
            DgvResultados.DataSource = services.GetAllResultadoByCedula(cedula);
        }

        private void BtnFiltrar_Click_1(object sender, EventArgs e)
        {
            string cedula = TxtFiltrar.Text;

            if (cedula == "")
            {
                MessageBox.Show("Debe ingresar una cedula valida para realizar la busqueda", "Advertencia");
            }
            else
            {
                bool isValidCedula = services.IsValidCedulaPaciente(cedula);

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

        private void BtnCrearCita_Click(object sender, EventArgs e)
        {

        }

        private void DgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
