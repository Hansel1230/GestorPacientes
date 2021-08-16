﻿using DataBase;
using DataBase.Modelos;
using System.Data;
using System.Data.SqlClient;

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

        public Usuario validLogin(Usuario user)
        {            
            return repositorio.validLogin(user);
        }        
        #endregion

        #region Usuario 

        public bool AgregarUsuario(Usuario usuario)
        {
            return repositorio.AgregarUsuario(usuario);
        }

        public bool EditarUsuario(Usuario usuario, int idUsuario)
        {
            return repositorio.EditarUsuario(usuario, idUsuario);
        }

        public bool EliminarUsuario(int id)
        {
            return repositorio.EliminarUsuario(id);
        }

        public DataTable GetAllUsuario()
        {
            return repositorio.GetAllUsuario();
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

        public DataTable GetAllMedico()
        {
            return repositorio.GetAllMedico();
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

        public DataTable GetAllPaciente()
        {
            return repositorio.GetAllPaciente();
        }
        #endregion

        #region Puebas
        public bool EliminarPrueva(int id)
        {
            return repositorio.EliminarPrueba(id);
        }
        #endregion

        #region Foto

        public bool SavePhoto(int id, string destination)
        {
            return repositorio.SavePhoto(id, destination);
        }
        public int GetLastId()
        {
            return repositorio.GetLastId();
        }
        #endregion

        public DataTable GetAllPrueba()
        {
            return repositorio.GetAllPrueba();
        }

        public DataTable GetAllResultado()
        {
            return repositorio.GetAllResultado();
        }

        public DataTable GetAllCita()
        {
            return repositorio.GetAllCita();
        }

    }
}
