using DataBase;
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

        public bool validDuplicados(string user)
        {
            return repositorio.validDuplicados(user);
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

        public bool getValidDelectMedico(int idMedico)
        {
            return repositorio.getValidDelectMedico(idMedico);
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

        public bool getValidDelectPaciente(int idPaciente)
        {
            return repositorio.getValidDelectPaciente(idPaciente);

        }
        public bool EliminarCita(int id)
        {
            return repositorio.EliminarCita(id);
        }
        #endregion

        #region Puebas

        public bool AgregarPrueba(PruebaLaboratorio prueba)
        {
            return repositorio.AgregarPrueba(prueba);

        }

        public bool EditarPreba(PruebaLaboratorio prueba, int idprueba)
        {
            return repositorio.EditarPrueba(prueba, idprueba);
        }

        public bool EliminarPrueva(int id)
        {
            return repositorio.EliminarPrueba(id);
        }

        public DataTable GetAllPrueba()
        {
            return repositorio.GetAllPrueba();
        }

        public bool getValidDelectPrueba(int idprueba)
        {
            return repositorio.getValidDelectPrueba(idprueba);
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

        #region GetAllLossquefaltan

        

        public DataTable GetAllResultado()
        {
            return repositorio.GetAllResultado();
        }

        public DataTable GetAllCita()
        {
            return repositorio.GetAllCita();
        }

        public DataTable GetAllAviablePacientes()
        {
            return repositorio.GetAllAviablePacientes();
        }

        public DataTable GetAllAviablePacientesByCedula(string cedula)
        {
            return repositorio.GetAllAviablePacientesByCedula(cedula);
        }

        public bool IsValidCedulaPaciente(string cedula)
        {
            return repositorio.IsValidCedulaPaciente(cedula);
        }

        public DataTable GetAllAviableMedicos()
        {
            return repositorio.GetAllAviableMedicos();
        }

        public DataTable GetAllAviableMedicosByCedula(string cedula)
        {
            return repositorio.GetAllAviableMedicosByCedula(cedula);
        }

        public bool IsValidCedulaMedico(string cedula)
        {
            return repositorio.IsValidCedulaMedico(cedula);
        }

        public bool AgregarCita(Citas cita)
        {
            return repositorio.AgregarCita(cita);
        }

        public string GetIdPacienteCita(int idcita)
        {
            return repositorio.GetIdPacienteCita(idcita);
        }

        public string GetIdMedicoCita(int idcita)
        {
            return repositorio.GetIdMedicoCita(idcita);
        }

        public bool CambiarEstadoCita(int estado, int idcita)
        {
            return repositorio.CambiarEstadoCita(estado, idcita);
        }

        public bool AgregarResultadoLaboratorio(ResultPruebaLaboratorio resultado)
        {
            return repositorio.AgregarResultadoLaboratorio(resultado);
        }

        public DataTable GetAllResultadoLPC(int idCita)
        {
            return repositorio.GetAllResultadoLPC(idCita);
        }


        public DataTable GetAllResultadoByCedula(string cedula)
        {
            return repositorio.GetAllResultadoByCedula(cedula);
        }
        #endregion
    }
}
