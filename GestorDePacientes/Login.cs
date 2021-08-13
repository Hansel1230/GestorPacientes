using System;
using System.Windows.Forms;

namespace GestorDePacientes
{
    public sealed  partial class Login : Form
    {
        #region instancia
        public static Login Instancia { get; } = new Login();
        #endregion
        bool isValid;

        private Login()
        {
            InitializeComponent();
        }

        #region Eventos 
        private void LblLogin_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Fultxt();
        }

        private void BtnIniciarSeccion_Click(object sender, EventArgs e)
        {
            isValid = true;
            if (TxtUsuario.Text == "Ingrese usuario")
            {
                MessageBox.Show("Debe ingresar un usuario");
                isValid = false;
            }
            else if (TxtContrasena.Text == "Ingrese Contraseña")
            {
                MessageBox.Show("Debe ingresar una contraseña");
                isValid = false;
            }

            if (isValid)
            {
                MenuHome.Instancia.Show();
                Instancia.Hide();
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

        //Mantenimiento Txt.Usuario
        private void TxtContrasena_Click(object sender, EventArgs e)
        {
            if (TxtContrasena.Text== "Ingrese Contraseña")
            {
                TxtContrasena.Text = "";
            }
        }

        private void TxtContrasena_Leave(object sender, EventArgs e)
        {
            if (TxtContrasena.Text=="")
            {
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

       
    }
}
