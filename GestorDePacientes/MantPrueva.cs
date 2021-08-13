using System;
using System.Windows.Forms;

namespace GestorDePacientes
{
    public partial class MantPrueva : Form
    {
        #region instancia
        public static MantPrueva Instancia { get; } = new MantPrueva();
        #endregion

        bool isValid;
        public MantPrueva()
        {
            InitializeComponent();
        }

        #region eventos
        private void MantPrueva_Load(object sender, EventArgs e)
        {
            fulltxt();
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

            if (TxtNombre.Text == "Ingrese Nombre")
            {
                MessageBox.Show("Debe ingresar un Nombre");
                isValid = false;
            }
            if (isValid)
            {
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

        #endregion


    }
}
