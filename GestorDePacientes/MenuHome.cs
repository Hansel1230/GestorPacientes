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
    public partial class MenuHome : Form
    {
        #region instancia
        public static MenuHome Instancia { get; } = new MenuHome();
        #endregion

        public string TipoMant { get; set; }

        public MenuHome()
        {
            InitializeComponent();
        }


        #region Eventos 

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            Dgv.Instancia.Show();
            Instancia.Hide();
            TipoMant = "Usuario";
        }

        private void BtnMedico_Click(object sender, EventArgs e)
        {
            Dgv.Instancia.Show();
            Instancia.Hide();
            TipoMant = "Medico";
        }

        private void BtnPrLabo_Click(object sender, EventArgs e)
        {
            Dgv.Instancia.Show();
            Instancia.Hide();
            TipoMant = "PrLabo";
        }

        private void BtnPaciente_Click(object sender, EventArgs e)
        {
            Dgv.Instancia.Show();
            Instancia.Hide();
            TipoMant = "Paciente";
        }

        private void BtnCita_Click(object sender, EventArgs e)
        {
            Dgv.Instancia.Show();
            Instancia.Hide();
            TipoMant = "Cita";
        }

        private void BtnResulPrLabo_Click(object sender, EventArgs e)
        {
            Dgv.Instancia.Show();
            Instancia.Hide();
            TipoMant = "ResulPrLabo";
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.Instancia.Show();
            Instancia.Hide();
           
        }

        #endregion


    }
}
