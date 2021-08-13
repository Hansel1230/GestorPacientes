using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Modelos;
using DataBase;

namespace BusinesLayer
{
    public class GestorPacientesServices
    {
        private RepositorioGestorPacientes repositorio;
            
        public GestorPacientesServices(SqlConnection connection)
        {
            repositorio = new RepositorioGestorPacientes(connection);
        }

        #region login

        public bool loginReader { get; set; }

        public bool validLogin(string user, string contrasena)
        {
            repositorio.LoginReader = loginReader;

            repositorio.validLogin(user, contrasena);

            return loginReader;
        }
        #endregion

        #region Usuario 

        public bool AgregarUsuario(Usuario usuario)
        {
            return repositorio.AgregarUsuario(usuario);
        }

        public bool EditarUsuario(Usuario usuario, int idUsuario)
        {

            return repositorio.EditarUsuario(usuario,idUsuario);
        }

        public bool EliminarUsuario(int id)
        {
            return repositorio.EliminarUsuario(id);
        }
        #endregion


        #region Medico 

        public bool AgregarMedico(Medico medico)
        {
            return repositorio.AgregarMedico(medico);
        }

        public bool EditarMedico(Medico medico, int idMedico)
        {

            return repositorio.EditarMedico(medico, idMedico);
        }

        public bool EliminarMedico(int id)
        {
            return repositorio.EliminarMedico(id);
        }
        #endregion


        #region Pacientes 

        public bool AgregarPaciente(Paciente paciente)
        {
            return repositorio.AgregarPaciente(paciente);
        }

        public bool EditarPaciente(Paciente paciente, int idpaciente)
        {
            return repositorio.EditarPaciente(paciente, idpaciente);
        }

        public bool EliminarPaciente(int id)
        {
            return repositorio.EliminarPaciente(id);
        }
        #endregion
        
    }
}
