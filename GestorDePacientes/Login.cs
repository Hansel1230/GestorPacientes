using System;
using System.Windows.Forms;
using BusinesLayer;
using System.Data.SqlClient;
using System.Configuration;
using DataBase.Modelos;

namespace GestorDePacientes
{
    public sealed  partial class Login : Form
    {
        #region instancia
        public static Login Instancia { get; } = new Login();
        #endregion

        private GestorPacientesServices services;
       

        private Login()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            services = new GestorPacientesServices(connection);

        }

        #region Eventos 
        private void LblLogin_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Fultxt();
        }

        private void BtnIniciarSeccion_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Ingrese usuario")
            {
                MessageBox.Show("Debe ingresar un usuario");
            }
            else if (TxtContrasena.Text == "Ingrese Contraseña")
            {
                MessageBox.Show("Debe ingresar una contraseña");
            }
            else
            {
                Usuario user = new Usuario(TxtUsuario.Text, TxtContrasena.Text);
                Usuario usuario = services.validLogin(user);

                if (usuario.NombreUser!=null)
                {
                    MenuHome.Instancia.HomeValid = usuario.TipoUser;
                    MessageBox.Show("Bienvenido " + user.NombreUser,"Info");
                    MenuHome.Instancia.Show();
                    Instancia.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales Invalidas", "Error");
                }
            }
        }

        //Mantenimiento Txt.Usuario
        private void TxtUsuario_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Ingrese usuario")
            {
                TxtUsuario.Text = "";
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "Ingrese usuario";
            }
        }

        //Mantenimiento Txt.Contraseña
        private void TxtContrasena_Click(object sender, EventArgs e)
        {
            if (TxtContrasena.Text== "Ingrese Contraseña")
            {
                TxtContrasena.Text = "";
                TxtContrasena.PasswordChar = '*';
                TxtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void TxtContrasena_Leave(object sender, EventArgs e)
        {
            if (TxtContrasena.Text=="")
            {
                TxtContrasena.UseSystemPasswordChar = false;
                TxtContrasena.Text = "Ingrese Contraseña";

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
        #endregion

        #region Metodos

        public void Fultxt()
        {
            TxtUsuario.Text = "Ingrese usuario";
            TxtContrasena.Text = "Ingrese Contraseña";
        }

        #endregion

        private void TxtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
