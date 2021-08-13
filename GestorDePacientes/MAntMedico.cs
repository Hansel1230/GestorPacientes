using System.Windows.Forms;

namespace GestorDePacientes
{

    public partial class MAntMedico : Form
    {
        #region instancia
        public static MAntMedico Instancia { get; } = new MAntMedico();
        #endregion

        bool isValid;

        public MAntMedico()
        {
            InitializeComponent();
        }

        #region Eventos 

        private void MAntMedico_Load(object sender, System.EventArgs e)
        {
            Fultxt();
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
                Dgv.Instancia.Show();
                Instancia.Hide();
            }
        }       
        #endregion

        
    }
}
