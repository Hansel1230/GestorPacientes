using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        #endregion

        bool isValid;

        public MantPAcientes()
        {
            InitializeComponent();
        }

        #region Eventos 

        private void MantPAcientes_Load(object sender, EventArgs e)
        {
            Fulltxt();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            validAdd();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuHome.Instancia.Show();
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
                Dgv.Instancia.Show();
                Instancia.Hide();
            }
        }    
        #endregion       
    }
}
