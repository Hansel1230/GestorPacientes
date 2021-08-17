using BusinesLayer;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestorDePacientes
{
    public partial class MantPrueva : Form
    {
        #region instancia
        public static MantPrueva Instancia { get; } = new MantPrueva();
        #endregion

        bool isValid;

        public int PruebaId { get; set; } = 0;

        private GestorPacientesServices services;

        public MantPrueva()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            services = new GestorPacientesServices(connection);

            
        }

        #region eventos
        private void MantPrueva_Load(object sender, EventArgs e)
        {
            //fulltxt();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dgv.Instancia.Show();
            Instancia.Hide();
        }

        private void TxtNombre_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "Ingrese Nombre")
            {
                TxtNombre.Text = "";
            }
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                TxtNombre.Text = "Ingrese Nombre";
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            isValid = true;

            if (TxtNombre.Text == "Ingrese Nombre"|| TxtNombre.Text =="")
            {
                MessageBox.Show("Debe ingresar un Nombre");
                isValid = false;
            }

            if (isValid)
            {
                DataBase.Modelos.PruebaLaboratorio prueba = new DataBase.Modelos.PruebaLaboratorio(TxtNombre.Text);

                if (PruebaId > 0)
                {
                    MessageBox.Show("Edit");
                    services.EditarPreba(prueba, PruebaId);
                    PruebaId = 0;
                }
                else
                {                    
                    services.AgregarPrueba(prueba);
                    MessageBox.Show("Add");
                }
                Dgv.Instancia.LoadData();
                Dgv.Instancia.Show();
                Instancia.Hide();
            }
        }
        #endregion

        #region Metodos

        public void fulltxt()
        {
            TxtNombre.Text = "Ingrese Nombre";
        }

        public void LoadTxtPrueba()
        {
            PruebaId = Convert.ToInt32(Dgv.Instancia.Filaceleccionada.Cells[0].Value);
            TxtNombre.Text = Dgv.Instancia.Filaceleccionada.Cells[1].Value.ToString();
            Dgv.Instancia.Filaceleccionada = null;
        }

            #endregion
        }
    }
