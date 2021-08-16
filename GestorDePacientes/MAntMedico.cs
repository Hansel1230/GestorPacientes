using BusinesLayer;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace GestorDePacientes
{

    public partial class MAntMedico : Form
    {
        #region instancia
        public static MAntMedico Instancia { get; } = new MAntMedico();

        private GestorPacientesServices services;
        #endregion

        bool isValid;

        public string _filename;

        public int index { get; set; }

        public int Medicoid { get; set; }

        public MAntMedico()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            services = new GestorPacientesServices(connection);
            _filename = "";
            index=0;
            Medicoid = 0;
        }

        #region Eventos 

        private void MAntMedico_Load(object sender, System.EventArgs e)
        {
            //Fultxt();
        }

        private void BtnAgregar_Click(object sender, System.EventArgs e)
        {
            ValidAdd();
        }
        private void TxtTelefono_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void TxtNombre_Click(object sender, System.EventArgs e)
        {
            if (TxtNombre.Text == "Ingrese Nombre")
            {
                TxtNombre.Text = "";
            }
        }

        private void TxtNombre_Leave(object sender, System.EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                TxtNombre.Text = "Ingrese Nombre";
            }
        }

        private void TxtApellido_Click(object sender, System.EventArgs e)
        {
            if (TxtApellido.Text== "Ingrese Apellido")
            {
                TxtApellido.Text = "";
            }
        }

        private void TxtApellido_Leave(object sender, System.EventArgs e)
        {
            if (TxtApellido.Text=="")
            {
                TxtApellido.Text = "Ingrese Apellido";
            }
        }

        private void TxtTelefono_Click(object sender, System.EventArgs e)
        {
            if (TxtTelefono.Text== "Ingrese Telefono")
            {
                TxtTelefono.Text = "";
            }
        }

        private void TxtTelefono_Leave(object sender, System.EventArgs e)
        {
            if (TxtTelefono.Text=="")
            {
                TxtTelefono.Text = "Ingrese Telefono";
            }
        }

        private void TxtCedula_Click(object sender, System.EventArgs e)
        {
            if (TxtCedula.Text== "Ingrese Cedula")
            {
                TxtCedula.Text = "";
            }
        }

        private void TxtCedula_Leave(object sender, System.EventArgs e)
        {
            if (TxtCedula.Text=="")
            {
                TxtCedula.Text = "Ingrese Cedula";
            }
        }

        private void TxtCorreo_Click(object sender, System.EventArgs e)
        {
            if (TxtCorreo.Text== "Ingrese un Correo")
            {
                TxtCorreo.Text = "";
            }
        }

        private void TxtCorreo_Leave(object sender, System.EventArgs e)
        {
            if (TxtCorreo.Text=="")
            {
                TxtCorreo.Text = "Ingrese un Correo";

            }
        }

        private void BtnSubir_Click(object sender, System.EventArgs e)
        {
            AddFoto();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dgv.Instancia.Show();
        }
        #endregion

        #region Metodos 
        public void Fultxt()
        {          
            TxtNombre.Text = "Ingrese Nombre";
            TxtApellido.Text = "Ingrese Apellido";
            TxtTelefono.Text = "Ingrese Telefono";
            TxtCedula.Text = "Ingrese Cedula";
            TxtCorreo.Text = "Ingrese un Correo";
        }

        public void ValidAdd()
        {
            isValid = true;
            if (TxtNombre.Text == "Ingrese Nombre")
            {
                MessageBox.Show("Debe ingresar un Nombre");
                isValid = false;

            }
            else if (TxtApellido.Text == "Ingrese Apellido")
            {
                MessageBox.Show("Debe ingresar un Apellido");
                isValid = false;
            }
            else if (TxtTelefono.Text == "Ingrese Telefono")
            {
                MessageBox.Show("Debe ingresar un Telefono");
                isValid = false;
            }
            else if (TxtCedula.Text == "Ingrese Cedula")
            {
                MessageBox.Show("Debe Ingresar una Cedula");
                isValid = false;
            }
            else if (TxtCorreo.Text == "Ingrese un Correo")
            {
                MessageBox.Show("Debe ingresar un Correo");
                isValid = false;
            }
            if (isValid)
            {
                //SavePhoto();
                DataBase.Modelos.Medico medico = new DataBase.Modelos.Medico(TxtNombre.Text, TxtApellido.Text,
                    TxtCorreo.Text, TxtTelefono.Text, TxtCedula.Text,  TxtTelefono.Text);
                //se repite Txttelefono.Text para evitar el error, en su lugar debe ir el string "foto"

                if (Medicoid > 0)
                {
                    services.EditarMedico(medico, Medicoid);
                    Medicoid = 0;
                }
                else
                {
                    services.AgregarMedico(medico);
                }
                Dgv.Instancia.LoadData();
                Dgv.Instancia.Show();
                Instancia.Hide();
            }
        }

        private void AddFoto()
        {
            DialogResult result = FotoDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = FotoDialog.FileName;                
                pbFotoPerfil.ImageLocation = file;
                _filename=file;
            }
        }
        
        private void SavePhoto()
        {            
             int id=Medicoid == 0 ? services.GetLastId() : Medicoid;

            string directory = @"Images\Medico\" + id + "\\";

            string[] fileNameSplit = _filename.Split('\\');
            string filename = fileNameSplit[(fileNameSplit.Length - 1)];

            CreateDirectory(directory);

            string destination = directory + filename;

            File.Copy(_filename,destination,true);

            services.SavePhoto(id, destination);
        }

        private void CreateDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        #endregion

        public void LoadTxtMedico()
        {
            Medicoid = Convert.ToInt32(Dgv.Instancia.Filaceleccionada.Cells[0].Value);
            TxtNombre.Text = Dgv.Instancia.Filaceleccionada.Cells[1].Value.ToString();
            TxtApellido.Text = Dgv.Instancia.Filaceleccionada.Cells[2].Value.ToString();
            TxtCorreo.Text = Dgv.Instancia.Filaceleccionada.Cells[3].Value.ToString();
            TxtTelefono.Text = Dgv.Instancia.Filaceleccionada.Cells[3].Value.ToString();
            TxtCedula.Text = Dgv.Instancia.Filaceleccionada.Cells[3].Value.ToString();
            //txt.Text = Dgv.Instancia.Filaceleccionada.Cells[3].Value.ToString();
            Dgv.Instancia.Filaceleccionada = null;
        }        
    }
}
