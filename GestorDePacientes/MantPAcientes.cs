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
    public partial class MantPAcientes : Form
    {
        #region instancia
        public static MantPAcientes Instancia { get; } = new MantPAcientes();

        private GestorPacientesServices services;
        #endregion

        bool isValid;
        private bool fumador { get; set; }
        public int PacienteId { get; set; }
        public MantPAcientes()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            services = new GestorPacientesServices(connection);
            PacienteId = 0;
            fumador = false;
        }

        #region Eventos 

        private void MantPAcientes_Load(object sender, EventArgs e)
        {
            //Fulltxt();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            validAdd();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dgv.Instancia.Show();
            Instancia.Hide();
        }
        private void TxtNombre_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text== "Ingrese Nombre")
            {
                TxtNombre.Text = "";
            }
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (TxtNombre.Text=="")
            {
                TxtNombre.Text = "Ingrese Nombre";
            }
        }

        private void TxtApellido_Click(object sender, EventArgs e)
        {
            if (TxtApellido.Text== "Ingrese Apellido")
            {
                TxtApellido.Text = "";
            }
        }

        private void TxtApellido_Leave(object sender, EventArgs e)
        {
            if (TxtApellido.Text=="")
            {
                TxtApellido.Text = "Ingrese Apellido";

            }
        }

        private void TxtTelefono_Click(object sender, EventArgs e)
        {
            if (TxtTelefono.Text== "Ingrese Telefono")
            {
                TxtTelefono.Text = "";
            }
        }

        private void TxtTelefono_Leave(object sender, EventArgs e)
        {
            if (TxtTelefono.Text=="")
            {
                TxtTelefono.Text = "Ingrese Telefono";

            }
        }

        private void TxtDress_Click(object sender, EventArgs e)
        {
            if (TxtDress.Text == "Ingrese Direccion")
            {
                TxtDress.Text = "";
            }
        }

        private void TxtDress_Leave(object sender, EventArgs e)
        {
            if (TxtDress.Text=="")
            {
                TxtDress.Text = "Ingrese Direccion";
            }
        }
        private void TxtCedula_Click(object sender, EventArgs e)
        {
            if (TxtCedula.Text == "Ingrese Cedula") 
            {
                TxtCedula.Text = "";
            }
        }

        private void TxtCedula_Leave(object sender, EventArgs e)
        {
            if (TxtCedula.Text=="")
            {
                TxtCedula.Text = "Ingrese Cedula";
            }
        }

        private void TxtDate_Click(object sender, EventArgs e)
        {
            if (TxtDate.Text== "Ingrese Fecha de Nacimiento")
            {
                TxtDate.Text = "";
            }
        }

        private void TxtDate_Leave(object sender, EventArgs e)
        {
            if (TxtDate.Text=="")
            {
                TxtDate.Text = "Ingrese Fecha de Nacimiento";
            }
        }
        private void TxtAlergias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese Alergias. De no tener, Ingrese 'No aplica'.");

            if (TxtAlergias.Text== "Ingrese Alergias")
            {
                TxtAlergias.Text = "";
            }
        }

        private void TxtAlergias_Leave(object sender, EventArgs e)
        {
            if (TxtAlergias.Text=="")
            {
                TxtAlergias.Text= "Ingrese Alergias";
            }
        }

        private void ChBoxFumador_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBoxFumador.Checked == true)
            {
                fumador = true;
            }
        }
        #endregion

        #region Metodos
        public void Fulltxt()
        {
            TxtNombre.Text = "Ingrese Nombre";
            TxtApellido.Text = "Ingrese Apellido";
            TxtTelefono.Text = "Ingrese Telefono";
            TxtDress.Text = "Ingrese Direccion";
            TxtCedula.Text = "Ingrese Cedula";
            TxtDate.Text = "Ingrese Fecha de Nacimiento";
            TxtAlergias.Text = "Ingrese Alergias";
        }

        public void validAdd()
        {
            isValid = true;

            if (TxtNombre.Text== "Ingrese Nombre")
            {
                MessageBox.Show("debe ingresar un Nombre");
                isValid = false;
            }
            else if (TxtApellido.Text== "Ingrese Apellido")
            {
                MessageBox.Show("debe ingresar un Apellido");
                isValid = false;
            }
            else if (TxtTelefono.Text == "Ingrese Telefono")
            {
                MessageBox.Show("debe ingresar un Telefono");
                isValid = false;
            }
            else if (TxtDress.Text == "Ingrese Direccion")
            {
                MessageBox.Show("debe ingresar un Direccion");
                isValid = false;
            }
            else if (TxtCedula.Text == "Ingrese Cedula")
            {
                MessageBox.Show("debe ingresar una Cedula");
                isValid = false;
            }
            else if (TxtDate.Text == "Ingrese Fecha de Nacimiento")
            {
                MessageBox.Show("debe ingresar una Fecha de Nacimiento");
                isValid = false;
            }
            else if (TxtAlergias.Text == "Ingrese Alergias")
            {
                MessageBox.Show("debe ingresar un tipo de Alergia");
                isValid = false;
            }
            if (isValid)
            {
                
                string foto = "";
                DataBase.Modelos.Paciente paciente = new DataBase.Modelos.Paciente(TxtNombre.Text,TxtApellido.Text,
                    TxtTelefono.Text,TxtDress.Text,TxtCedula.Text,TxtDate.Text,fumador,TxtAlergias.Text,foto);
                //se le pasa  foto para evitar error y poder correr; eso se tiene que arreglar 
                if (PacienteId > 0)
                {
                    services.EditarPaciente(paciente, PacienteId);
                    PacienteId = 0;
                }
                else
                {
                    services.AgregarPaciente(paciente);
                }
                Dgv.Instancia.LoadData();              
                Dgv.Instancia.Show();
                Instancia.Hide();
                fumador = false;
            }
        }

        public void LoadTxtPaciente()
        {
            PacienteId = Convert.ToInt32(Dgv.Instancia.Filaceleccionada.Cells[0].Value);
            TxtNombre.Text = Dgv.Instancia.Filaceleccionada.Cells[1].Value.ToString();
            TxtApellido.Text = Dgv.Instancia.Filaceleccionada.Cells[2].Value.ToString();
            TxtTelefono.Text = Dgv.Instancia.Filaceleccionada.Cells[3].Value.ToString();
            TxtDress.Text = Dgv.Instancia.Filaceleccionada.Cells[4].Value.ToString();
            TxtCedula.Text = Dgv.Instancia.Filaceleccionada.Cells[5].Value.ToString();
            TxtDate.Text = Dgv.Instancia.Filaceleccionada.Cells[6].Value.ToString();
            TxtAlergias.Text = Dgv.Instancia.Filaceleccionada.Cells[8].Value.ToString();
            Dgv.Instancia.Filaceleccionada = null;
        }

        #endregion


    }
}
