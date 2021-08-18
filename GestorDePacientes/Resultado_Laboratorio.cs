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
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            deselect();
        }
        #endregion

        #region Metodos

        public void LoadData()
        {
            try
            {
                //isValid = Convert.ToBoolean(
                isValid = Convert.ToBoolean(DgvResultados.DataSource = services.GetAllResultado());
                //DgvResultados.ClearSelection();
                MessageBox.Show("Pase");
                if (isValid == false)
                {
                    MessageBox.Show("No tiene resultados pendientes, primero ingrese para poder acceder a ese apartado");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exploto");
            }
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
    }
}
