#region Dependencias

using BusinesLayer;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

#endregion

namespace GestorDePacientes
{
    public partial class Dgv : Form
    {
        #region instancia
        public static Dgv Instancia { get; } = new Dgv();
        #endregion

        #region Props
        private GestorPacientesServices services;

        public DataGridViewRow Filaceleccionada = null;

        private int index = 0;
        #endregion

        #region Constructor
        public Dgv()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            services = new GestorPacientesServices(connection);

        }
        #endregion

        #region Eventos 

        private void Dgv_Load(object sender, EventArgs e)
        {
            deselect();
            LoadData();
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
            validDelect();
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            deselect();
        }

        private void Dgv_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Filaceleccionada = DgvData.Rows[e.RowIndex];
                BtnEditar.Visible = true;
                BtnEliminar.Visible = true;
                BtnDeselect.Visible = true;

                index = Convert.ToInt32(DgvData.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        #region Metodos

        public void deselect()
        {
            BtnEditar.Visible = false;
            BtnEliminar.Visible = false;
            BtnDeselect.Visible = false;
            DgvData.ClearSelection();
            //index = null;
        }

        public void validDelect()
        {
            if (MenuHome.Instancia.TipoMant == "Usuario")
            {
                DialogResult response = MessageBox.Show("Esta seguro de eliminar este " +
                    "Usuario?", "Advertencia", MessageBoxButtons.OKCancel);
                if (response == DialogResult.OK)
                {
                    bool result = services.EliminarUsuario(index);

                    if (result)
                    {
                        MessageBox.Show("Se elimino con exito!!", "succes");
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error", "Bad News");
                    }
                }
            }
            else if (MenuHome.Instancia.TipoMant == "Medico")
            {
                DialogResult response = MessageBox.Show("Esta seguro de eliminar este " +
                    "Medico?", "Advertencia", MessageBoxButtons.OKCancel);
                if (response == DialogResult.OK)
                {
                    bool result = services.EliminarMedico(index);

                    if (result)
                    {
                        MessageBox.Show("Se elimino con exito!!", "succes");
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error", "Bad News");
                    }
                }
            }
            else if (MenuHome.Instancia.TipoMant == "PrLabo")
            {
                DialogResult response = MessageBox.Show("Esta seguro de eliminar esta " +
                    "Prueba?", "Advertencia", MessageBoxButtons.OKCancel);
                if (response == DialogResult.OK)
                {
                    bool result = services.EliminarPrueva(index);

                    if (result)
                    {
                        MessageBox.Show("Se elimino con exito!!", "succes");
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error", "Bad News");
                    }
                }
            }
            else if (MenuHome.Instancia.TipoMant == "Paciente")
            {
                DialogResult response = MessageBox.Show("Esta seguro de eliminar este " +
                    "Paciente?", "Advertencia", MessageBoxButtons.OKCancel);
                if (response == DialogResult.OK)
                {
                    bool result = services.EliminarPaciente(index);

                    if (result)
                    {
                        MessageBox.Show("Se elimino con exito!!", "succes");
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error", "Bad News");
                    }
                }
            }
            /*else if (MenuHome.Instancia.TipoMant == "Cita")
            {

            }*/
            else if (MenuHome.Instancia.TipoMant == "ResulPrLabo")
            {

            }
            LoadData();
            deselect();
        }

        public void validAdd()
        {
            if (MenuHome.Instancia.TipoMant == "Usuario")
            {
                if (Filaceleccionada != null)
                {
                    MantUsuario.Instancia.LoadTxtUsuario();
                }
                MantUsuario.Instancia.Show();
                Instancia.Hide();

            }
            else if (MenuHome.Instancia.TipoMant == "Medico")
            {
                if (Filaceleccionada != null)
                {
                   // MantUsuario.Instancia.LoadTxt();
                }
                MAntMedico.Instancia.Show();
                Instancia.Hide();
            }
            else if (MenuHome.Instancia.TipoMant == "PrLabo")
            {
                if (Filaceleccionada != null)
                {
                   // MantUsuario.Instancia.LoadTxt();
                }
                MantPrueva.Instancia.Show();
                Instancia.Hide();
            }
            else if (MenuHome.Instancia.TipoMant == "Paciente")
            {
                if (Filaceleccionada != null)
                {
                   // MantUsuario.Instancia.LoadTxt();
                }
                MantPAcientes.Instancia.Show();
                Instancia.Hide();
            }
            else if (MenuHome.Instancia.TipoMant == "Cita")
            {
                if (Filaceleccionada != null)
                {
                   // MantUsuario.Instancia.LoadTxt();
                }
                //MantCita.Instancia.Show();
                Instancia.Hide();
            }
            else if (MenuHome.Instancia.TipoMant == "ResulPrLabo")
            {
                if (Filaceleccionada != null)
                {
                   // MantUsuario.Instancia.LoadTxt();
                }

                //ResultPruevaLabo.Instancia.Show();
                Instancia.Hide();
            }
        }

        public void LoadData()
        {
            if (MenuHome.Instancia.TipoMant== "Usuario")
            {
                DgvData.DataSource = services.GetAllUsuario();                
            }

            else if (MenuHome.Instancia.TipoMant == "Medico")
            {
                DgvData.DataSource = services.GetAllMedico();                
            }

            else if (MenuHome.Instancia.TipoMant == "PrLabo")
            {
                DgvData.DataSource = services.GetAllPrueba();
            }

            else if (MenuHome.Instancia.TipoMant == "Paciente")
            {
                DgvData.DataSource = services.GetAllPaciente();
            }

            else if (MenuHome.Instancia.TipoMant == "Cita")
            {
                DgvData.DataSource = services.GetAllCita();
            }

            else if (MenuHome.Instancia.TipoMant == "ResulPrLabo")
            {
                DgvData.DataSource = services.GetAllResultado();
            }
            DgvData.ClearSelection();
        }
        #endregion
    }
}
