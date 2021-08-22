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
    public partial class formularioCita : Form
    {
        public static formularioCita Instancia { get; } = new formularioCita();

        private GestorPacientesServices services;

        public formularioCita()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            services = new GestorPacientesServices(connection);
        }


        public void LoadData()
        {
            txtNombrePaciente.Text = FomBusqueda.Instancia.nombrePaciente;
            txtNombreDoctor.Text = FomBusqueda.Instancia.nombreMedico;
        }

        public bool fechaValida()
        {
            try
            {
                DateTime dateTime = DateTime.Parse(txtFecha.Text + " " + txtHora.Text);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (TxtCausa.Text == "" || !fechaValida())
            {
                MessageBox.Show("Informacion incorrecta\nDebe ingresar la informacion en cada campo disponible", "Advertencia");
            }
            else
            {
                int idPaciente = FomBusqueda.Instancia.pacienteId;
                int idMedico = FomBusqueda.Instancia.MedicoId;
                int estadoCita = 0;
                string fecha_horaCita = txtFecha.Text + " " + txtHora.Text;
                string causaCita = TxtCausa.Text;

                DataBase.Modelos.Citas cita = 
                    new DataBase.Modelos.Citas(idPaciente,idMedico,estadoCita,fecha_horaCita,causaCita );

                bool isCitaOk = services.AgregarCita(cita);

                if (isCitaOk)
                {
                    MessageBox.Show("Cita agregada exitosamente", "Exito");
                    Instancia.Hide();
                    Dgv.Instancia.LoadData();
                    Dgv.Instancia.Show();

                }
                else
                {
                    MessageBox.Show("Error al crear la cita", "Advertencia");
                }
            }
        }
    }
}
