using BusinesLayer;
using BusinesLayer.CustomControlItem;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using EmailHandler;

namespace GestorDePacientes
{
    public partial class MantUsuario : Form
    {
        #region instancias
        public static MantUsuario Instancia { get; } = new MantUsuario();

        private GestorPacientesServices services;
        #endregion

        #region props
        bool isValid;
        public int Usuarioid { get; set; } = 0;
        public int tipoUser { get; set; }

        private EmailSender emailSender;
        #endregion

        public MantUsuario()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            services = new GestorPacientesServices(connection);

            emailSender = new EmailSender();

        }

        #region Eventos
        private void MantUsuario_Load(object sender, EventArgs e)
        {
           // Fultxt();
            loadCombobox();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ValidAdd();
        }

        //Nombre
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

        //Apellido
        private void TxtApellido_Click(object sender, EventArgs e)
        {
            if (TxtApellido.Text == "Ingrese Apellido")
            {
                TxtApellido.Text = "";
            }
        }

        private void TxtApellido_Leave(object sender, EventArgs e)
        {
            if (TxtApellido.Text == "")
            {
                TxtApellido.Text = "Ingrese Apellido";
            }
        }
        //Correo
        private void TxtCorreo_Click(object sender, EventArgs e)
        {
            if (TxtCorreo.Text == "Ingrese un Correo")
            {
                TxtCorreo.Text = "";
            }
        }

        private void TxtCorreo_Leave(object sender, EventArgs e)
        {
            if (TxtCorreo.Text == "")
            {
                TxtCorreo.Text = "Ingrese un Correo";
            }
        }
        //Usuario
        private void TxtUsuario_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Ingrese Usuario")
            {
                TxtUsuario.Text = "";
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "Ingrese Usuario";
            }
        }
        //Contrasena
        private void TxtContrasena_Click(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "Ingrese Contraseña"|| TxtContrasena.Text == "Ingrese Nueva Contraseña")
            {
                TxtContrasena.Text = "";
            }
        }

        private void TxtContrasena_Leave(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "")
            {
                TxtContrasena.Text = "Ingrese Contraseña";
            }
        }
        //confiContrasena
        private void TxtConfiContrasena_Click(object sender, EventArgs e)
        {
            if (TxtConfiContrasena.Text == "Confirme Contraseña")
            {
                TxtConfiContrasena.Text = "";
            }
        }

        private void TxtConfiContrasena_Leave(object sender, EventArgs e)
        {
            if (TxtConfiContrasena.Text == "")
            {
                TxtConfiContrasena.Text = "Confirme Contraseña";
            }
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dgv.Instancia.Show();
            Instancia.Hide();
        }

        private void CbxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoUser = CbxRol.SelectedIndex -1;
        }
        #endregion

        #region Metodos 
        public void Fultxt()
        {
            TxtUsuario.Text = "Ingrese Usuario";
            TxtContrasena.Text = "Ingrese Contraseña";
            TxtApellido.Text = "Ingrese Apellido";
            TxtConfiContrasena.Text = "Confirme Contraseña";
            TxtCorreo.Text = "Ingrese un Correo";
            TxtNombre.Text = "Ingrese Nombre";
            loadCombobox();
        }

        public void ValidAdd()
        {
            //bool invalidUser = services.validDuplicados(TxtUsuario.Text);

            isValid = true;
            if (TxtNombre.Text == "Ingrese Nombre"|| TxtNombre.Text =="")
            {
                MessageBox.Show("Debe ingresar un Nombre");
                isValid = false;

            }
            else if (TxtApellido.Text == "Ingrese Apellido"|| TxtApellido.Text =="")
            {
                MessageBox.Show("Debe ingresar un Apellido");
                isValid = false;
            }
            else if (TxtCorreo.Text == "Ingrese un Correo"|| TxtCorreo.Text =="")
            {
                MessageBox.Show("Debe ingresar un Correo");
                isValid = false;
            }
            else if (TxtUsuario.Text == "Ingrese Usuario"|| TxtUsuario.Text =="")
            {
                MessageBox.Show("Debe ingresar un  Nombre de usuario");
                isValid = false;
            }
            
            else if (TxtContrasena.Text == "Ingrese Contraseña" || TxtContrasena.Text ==""|| TxtContrasena.Text == "Ingrese Nueva Contraseña")
            {
                MessageBox.Show("Debe ingresar una contraseña");
                isValid = false;
            }
            else if (TxtConfiContrasena.Text == "Confirme Contraseña"|| TxtConfiContrasena.Text =="")
            {
                MessageBox.Show("Debe confirmar la contraseña");
                isValid = false;
            }
            else if (TxtContrasena.Text != TxtConfiContrasena.Text)
            {
                MessageBox.Show("Debe ingresar una misma contraseña en ambos campos");
                isValid = false;
            }
            else if (CbxRol.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un Rol");
                isValid = false;
            }
           
            if (isValid)
            {
                DataBase.Modelos.Usuario usuario = new DataBase.Modelos.Usuario(TxtNombre.Text, TxtApellido.Text,
                    TxtCorreo.Text, TxtUsuario.Text, TxtContrasena.Text, tipoUser);

                if (Usuarioid > 0)
                {
                    services.EditarUsuario(usuario, Usuarioid);
                    Usuarioid = 0;
                }               
                else
                {
                    string cuerpo ="Se ha agregado como usuario en " +
                        "'Gestor de Pacientes' a "+usuario.Nombre+" "+usuario.Apellido+
                        " y su Nombre de usuario es"+usuario.NombreUser;

                    services.AgregarUsuario(usuario);
                    emailSender.SendEmail(TxtCorreo.Text, "Se ha registrado en 'Gestor de Pacientes'", cuerpo);
                }
                Dgv.Instancia.LoadData();
                Dgv.Instancia.Show();
                Instancia.Hide();
            }
        }

        private void loadCombobox()
        {

            CbxRol.Items.Clear();

            ComboBoxItem OpcionDefecto = new ComboBoxItem();
            OpcionDefecto.Text = "Seleccione un rol";
            OpcionDefecto.Value = null;
            CbxRol.Items.Add(OpcionDefecto);

            ComboBoxItem Usuario = new ComboBoxItem();
            Usuario.Text = "Medico";
            Usuario.Value = 0;
            CbxRol.Items.Add(Usuario);

            ComboBoxItem Administrador = new ComboBoxItem();
            Administrador.Text = "Administrador";
            Administrador.Value = 1;
            CbxRol.Items.Add(Administrador);


            CbxRol.SelectedItem = OpcionDefecto;


        }

        public void LoadTxtUsuario()
        {
            Usuarioid = Convert.ToInt32(Dgv.Instancia.Filaceleccionada.Cells[0].Value);
            TxtNombre.Text = Dgv.Instancia.Filaceleccionada.Cells[1].Value.ToString();
            TxtApellido.Text = Dgv.Instancia.Filaceleccionada.Cells[2].Value.ToString();
            TxtCorreo.Text = Dgv.Instancia.Filaceleccionada.Cells[3].Value.ToString();
            TxtUsuario.Text = Dgv.Instancia.Filaceleccionada.Cells[4].Value.ToString();
            TxtContrasena.Text ="Ingrese Nueva Contraseña";
            TxtConfiContrasena.Text = "Confirme Contraseña";
            //CbxRol.Text= Dgv.Instancia.Filaceleccionada.Cells[5].Value.ToString();
            loadCombobox();
            Dgv.Instancia.Filaceleccionada = null;
        }

        #endregion
    }
}
