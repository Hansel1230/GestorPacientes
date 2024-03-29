﻿
using DataBase.Modelos;
using System;
using System.Data;
using System.Data.SqlClient;
namespace DataBase
{
    public class RepositorioGestorPacientes
    {
        private SqlConnection _Connection;

        //private bool Valid = true;

        public int HomeValid { get; set; }

        public RepositorioGestorPacientes(SqlConnection Connection)
        {
            _Connection = Connection;
        }

        #region login 

        public Usuario validLogin(Usuario user)
        {
            _Connection.Open();

            SqlCommand command = new SqlCommand("select id,Nombre,Apellido,Correo,Nombre_Usuario,Contrasena,Tipo_Usuario from Usuarios" +
                " where Nombre_Usuario=@nombre_user and Contrasena=@contrasena", _Connection);



            command.Parameters.AddWithValue("@nombre_user", user.NombreUser);
            command.Parameters.AddWithValue("@contrasena", user.Contrasena);

            SqlDataReader reader = command.ExecuteReader();

            Usuario usuario = new Usuario();
            while (reader.Read())
            {
                usuario.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                usuario.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                usuario.Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2);
                usuario.Correo = reader.IsDBNull(3) ? "" : reader.GetString(3);
                usuario.NombreUser = reader.IsDBNull(4) ? "" : reader.GetString(4);
                usuario.Contrasena = reader.IsDBNull(5) ? "" : reader.GetString(5);
                usuario.TipoUser = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
            }

            reader.Close();
            reader.Dispose();
            _Connection.Close();
            return usuario;
        }

        #endregion

        #region Mant.bbdd.Usuario

        //Usuarios

        public bool AgregarUsuario(Usuario item)
        {
            SqlCommand command = new SqlCommand("insert into Usuarios(Nombre,Apellido,Correo,Nombre_Usuario,Contrasena," +
                "Tipo_Usuario) values (@nombre,@apellido,@correo,@nombre_user,@contrasena,@tipo_user)", _Connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@nombre_user", item.NombreUser);
            command.Parameters.AddWithValue("@contrasena", item.Contrasena);
            command.Parameters.AddWithValue("@tipo_user", item.TipoUser);

            return ExecuteDml(command);
        }

        public bool EditarUsuario(Usuario item, int idUsuario)
        {
            SqlCommand command = new SqlCommand("update Usuarios set Nombre=@nombre,Apellido=@apellido,Correo=@correo," +
                "Nombre_Usuario=@nombre_user,Contrasena=@contrasena,Tipo_Usuario=@tipo_user where id=@id", _Connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@nombre_user", item.NombreUser);
            command.Parameters.AddWithValue("@contrasena", item.Contrasena);
            command.Parameters.AddWithValue("@tipo_user", item.TipoUser);
            command.Parameters.AddWithValue("@id", idUsuario);

            return ExecuteDml(command);
        }

        public bool EliminarUsuario(int id)
        {
            SqlCommand command = new SqlCommand("delete Usuarios where id=@id", _Connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public bool validDuplicados(string user)
        {

            SqlDataAdapter query = new SqlDataAdapter("select * from Usuarios where Nombre_Usuario = " + user, _Connection);

            int valoruser = Convert.ToInt32(LoadData(query).Rows.Count);

            if (valoruser > 0)
            {
                return true;
            }

            return false;
        }
        #endregion

        #region Mant.bbdd.Medicos

        //Medicos

        public bool AgregarMedico(Medico item)
        {
            SqlCommand command = new SqlCommand("insert into Medicos(Nombre,Apellido,Correo,Telefono,Cedula,Foto) values (@nombre,@apellido,@correo,@telefono,@cedula,@foto)", _Connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@telefono", item.Telefono);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@foto", item.Foto);

            return ExecuteDml(command);
        }

        public bool EditarMedico(Medico item, int idMedico)
        {
            SqlCommand command = new SqlCommand("update Medicos set Nombre=@nombre,Apellido=@apellido,Correo=@correo," +
                "Telefono=@telefono,Cedula=@cedula,Foto=@foto where id=@id", _Connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@telefono", item.Telefono);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@foto", item.Foto);
            command.Parameters.AddWithValue("@id", idMedico);

            return ExecuteDml(command);
        }

        public bool EliminarMedico(int id)
        {
            SqlCommand command = new SqlCommand("delete Medicos where id=@id", _Connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }
        #endregion

        #region Mant.bbdd.Pacientes

        //Medicos

        public bool AgregarPaciente(Paciente item)
        {
            SqlCommand command = new SqlCommand("insert into Pacientes(Nombre,Apellido,Telefono,Direccion,Cedula," +
                "Fecha_Nacimiento,Fumador,Alergias,Foto) values (@nombre,@apellido,@telefono,@direccion,@cedula," +
                "@fecha_nacimiento,@fumador,@alergias,@foto)", _Connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@telefono", item.Telefono);
            command.Parameters.AddWithValue("@direccion", item.Direccion);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@fecha_nacimiento", item.Telefono);
            command.Parameters.AddWithValue("@fumador", item.Fumador);
            command.Parameters.AddWithValue("@alergias", item.Alergias);
            command.Parameters.AddWithValue("@foto", item.Foto);

            return ExecuteDml(command);
        }

        public bool EditarPaciente(Paciente item, int idPaciente)
        {
            SqlCommand command = new SqlCommand("update Pacientes set Nombre=@nombre,Apellido=@apellido,Telefono=@telefono," +
                "Direccion=@direccion,Cedula=@cedula,Fecha_Nacimiento=@fecha_nacimiento,Fumador=@fumador,Alergias=@alergias," +
                "Foto=@foto where id=@id", _Connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@telefono", item.Telefono);
            command.Parameters.AddWithValue("@direccion", item.Direccion);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@fecha_nacimiento", item.Datebirth);
            command.Parameters.AddWithValue("@fumador", item.Fumador);
            command.Parameters.AddWithValue("@alergias", item.Alergias);
            command.Parameters.AddWithValue("@foto", item.Foto);
            command.Parameters.AddWithValue("@id", idPaciente);

            return ExecuteDml(command);
        }

        public bool EliminarPaciente(int id)
        {
            SqlCommand command = new SqlCommand("delete Pacientes where id=@id", _Connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }
        #endregion

        #region Mant.bbdd.Pruebas_Laboratorio

        //Pruebas_Laboratorio

        public bool AgregarPrueba(PruebaLaboratorio item)
        {
            SqlCommand command = new SqlCommand("insert into Pruebas_Laboratorio(Nombre) values (@nombre)", _Connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);

            return ExecuteDml(command);
        }

        public bool EditarPrueba(PruebaLaboratorio item, int idPrueba)
        {
            SqlCommand command = new SqlCommand("update Pruebas_Laboratorio set Nombre=@nombre where id=@id", _Connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@id", idPrueba);

            return ExecuteDml(command);
        }

        public bool EliminarPrueba(int id)
        {
            SqlCommand command = new SqlCommand("delete Pruebas_Laboratorio where id=@id", _Connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public bool UpdateResultado(int idResultado, string Resultado)
        {

            SqlCommand command = new SqlCommand("UPDATE Resultados_Laboratorio SET " +
            "Resultado_Prueva=@resultado,Estado_Resultado=1 WHERE id=@id;", _Connection);

            command.Parameters.AddWithValue("@resultado", Resultado);
            command.Parameters.AddWithValue("@id", idResultado);

            return ExecuteDml(command);
        }
        #endregion

        #region Resultados

        /*public bool getCedulaResultado(String cedula)
        {
            SqlDataAdapter getCedularesultado = new SqlDataAdapter("select Nombre,Apellido,Cedula from Pacientes" +
                 " where Cedula=" + cedula, _Connection);

            //int valorLaboratorio = Convert.ToInt32(LoadData(get_resultado).Rows.Count);

            

            //int valorCita = Convert.ToInt32(LoadData(get_cita).Rows.Count);


            //if (valorLaboratorio > 0 || valorCita > 0)
            {
                return false;

            }

            return true;
        }
        */
        #endregion

        #region Mant.bbdd.Citas

        //Pruebas_Laboratorio
        public bool AgregarResultadoLaboratorio(ResultPruebaLaboratorio resultado)
        {

            SqlCommand command = new SqlCommand("insert into Resultados_Laboratorio " +
                "(idPaciente,idCita,idPrueva_Laboriatorio,idDoctor,Resultado_Prueva,Estado_Resultado) " +
                "values (@idPaciente,@idCita,@idPrueva_Laboriatorio,@idDoctor,@Resultado_Prueva,@Estado_Resultado) " +
                "", _Connection);

            command.Parameters.AddWithValue("@idpaciente", resultado.idPaciente);
            command.Parameters.AddWithValue("@idCita", resultado.idCita);
            command.Parameters.AddWithValue("@idPrueva_Laboriatorio", resultado.idPruebaLabo);
            command.Parameters.AddWithValue("@idDoctor", resultado.idDoctor);
            command.Parameters.AddWithValue("@Resultado_Prueva", resultado.ResultadoPrueva);
            command.Parameters.AddWithValue("@Estado_Resultado", resultado.EstadoResultado);


            return ExecuteDml(command);
        }

        public bool AgregarCita(Citas cita)
        {
            SqlCommand command = new SqlCommand("insert into Citas(idPaciente,idDoctor,Fecha_Hora_Cita,Causa_Cita," +
                "Estado_Cita) values (@idpaciente,@idDoctor,@fecha_hora_cita,@causa_cita,@estado_cita)", _Connection);

            command.Parameters.AddWithValue("@idpaciente", cita.idPaciente);
            command.Parameters.AddWithValue("@idDoctor", cita.idDoctor);
            command.Parameters.AddWithValue("@fecha_hora_cita", cita.FechaCita);
            command.Parameters.AddWithValue("@causa_cita", cita.CausaCita);
            command.Parameters.AddWithValue("@estado_cita", cita.EstadoCita);


            return ExecuteDml(command);
        }
        #endregion

        #region getAllData
        public DataTable GetAllUsuario()
        {
            //SqlDataAdapter query = new SqlDataAdapter("Select * from Usuarios", _Connection);
            SqlDataAdapter query = new SqlDataAdapter("select id,Nombre,Apellido,Correo,Nombre_Usuario," +
            "CASE WHEN Tipo_Usuario = 1 THEN 'Administrador' ELSE 'Medico' END AS 'Tipo de Usuario' from Usuarios", _Connection);

            return LoadData(query);
        }

        public DataTable GetAllMedico()
        {
            SqlDataAdapter query = new SqlDataAdapter("select id,Nombre,Apellido,Correo,Telefono,Cedula," +
                "Foto from Medicos", _Connection);

            return LoadData(query);
        }

        public DataTable GetAllPaciente()
        {
            SqlDataAdapter query = new SqlDataAdapter("select id,Nombre,Apellido,Telefono,Direccion,Cedula," +
                "Fecha_Nacimiento as 'Fecha de nacimiento'," +
                "CASE WHEN Fumador = 1 THEN 'Si' ELSE 'No' END AS Fumador, Alergias,Foto " +
                "from Pacientes", _Connection);

            return LoadData(query);
        }

        public DataTable GetAllPrueba()
        {
            SqlDataAdapter query = new SqlDataAdapter("select id,Nombre from Pruebas_Laboratorio", _Connection);

            return LoadData(query);
        }

        public DataTable GetAllResultado()
        {
            SqlDataAdapter query = new SqlDataAdapter("select Resultados_Laboratorio.id, " +
                "Pacientes.Nombre+' '+Pacientes.Apellido as 'Nombre Paciente',Pacientes.Cedula, " +
                "Pruebas_Laboratorio.Nombre as 'Nombre de Prueba' " +
                "FROM Resultados_Laboratorio " +
                "join Pacientes on Pacientes.id=Resultados_Laboratorio.idPaciente " +
                "join Pruebas_Laboratorio on Resultados_Laboratorio.idPrueva_Laboriatorio=Pruebas_Laboratorio.id " +
                "where Resultados_Laboratorio.Estado_Resultado = 0", _Connection);

            return LoadData(query);
        }

        public DataTable GetAllResultadoByCedula(string cedula)
        {
            SqlDataAdapter query = new SqlDataAdapter("select Resultados_Laboratorio.id, " +
                "Pacientes.Nombre+' '+Pacientes.Apellido as 'Nombre Paciente',Pacientes.Cedula, " +
                "Pruebas_Laboratorio.Nombre as 'Nombre de Prueba' " +
                "FROM Resultados_Laboratorio " +
                "join Pacientes on Pacientes.id=Resultados_Laboratorio.idPaciente " +
                "join Pruebas_Laboratorio on Resultados_Laboratorio.idPrueva_Laboriatorio=Pruebas_Laboratorio.id " +
                "where Resultados_Laboratorio.Estado_Resultado = 0 and Pacientes.Cedula = '" + cedula + "'", _Connection);

            return LoadData(query);
        }

        public DataTable GetAllResultadoLPC(int idCita)
        {
            SqlDataAdapter query = new SqlDataAdapter("select PL.Nombre, " +
               " Case when RL.Estado_Resultado = 0 then 'Pendiente' else 'Completado' end as 'Estado Resultado' " +
               " from Resultados_Laboratorio as RL join Pruebas_Laboratorio as PL on RL.idPrueva_Laboriatorio = PL.id " +
               " where idCita = " + idCita, _Connection);

            return LoadData(query);
        }

        public DataTable GetAllCita()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT citas.id as idCita, Pacientes.Nombre as 'Nombre Paciente'" +
                ",Medicos.Nombre as 'Nombre Medico',Fecha_Hora_Cita as 'Fecha y Hora',Causa_Cita as 'Causa de la cita', " +
                "CASE WHEN Estado_Cita = 0 THEN 'Pendiente de consulta' WHEN Estado_Cita = 1 THEN 'Pendiente de resultados' " +
                "ELSE 'Completa' END AS 'Estado de la cita' FROM Citas join Pacientes on Pacientes.id=Citas.idPaciente " +
                "join Medicos on Medicos.id=Citas.idDoctor", _Connection);

            return LoadData(query);
        }

        public DataTable GetAllAviablePacientes()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT Cedula, Nombre, Apellido, id From Pacientes", _Connection);

            return LoadData(query);
        }

        public DataTable GetAllAviablePacientesByCedula(string cedula)
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT Cedula, Nombre, Apellido, id From Pacientes where Cedula = '" + cedula + "'", _Connection);

            return LoadData(query);
        }

        public string GetIdPacienteCita(int idcita)
        {
            SqlCommand query = new SqlCommand("select idPaciente from Citas where id = '" + idcita + "'", _Connection);
            string value = GetExecuteDmlValue(query);
            return value;
        }

        public string GetIdMedicoCita(int idcita)
        {
            SqlCommand query = new SqlCommand("select idDoctor from Citas where id = '" + idcita + "'", _Connection);
            string value = GetExecuteDmlValue(query);
            return value;
        }

        public bool CambiarEstadoCita(int estado, int idcita)
        {
            SqlCommand command = new SqlCommand("update Citas set Estado_Cita=@estado where id=@id", _Connection);

            command.Parameters.AddWithValue("@estado", estado);
            command.Parameters.AddWithValue("@id", idcita);

            return ExecuteDml(command);
        }

        public bool EliminarCita(int id)
        {
            SqlCommand command = new SqlCommand("delete Citas where id=@id", _Connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public bool IsValidCedulaPaciente(string cedula)
        {
            SqlCommand query = new SqlCommand("select Cedula from Pacientes where Cedula= '" + cedula + "'", _Connection);

            if (GetExecuteDmlValue(query) != "")
            {
                return true;
            }

            return false;
        }

        public DataTable GetAllAviableMedicos()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT Cedula, Nombre, Apellido, id From Medicos", _Connection);

            return LoadData(query);
        }

        public DataTable GetAllAviableMedicosByCedula(string cedula)
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT Cedula, Nombre, Apellido, id From Medicos where Cedula = '" + cedula + "'", _Connection);

            return LoadData(query);
        }

        public bool IsValidCedulaMedico(string cedula)
        {
            SqlCommand query = new SqlCommand("select Cedula from Medicos where Cedula = '" + cedula + "'", _Connection);


            if (GetExecuteDmlValue(query) != "")
            {
                return true;
            }

            return false;
        }

        #endregion

        #region Acceso.coneccion
        public bool ExecuteDml(SqlCommand query)
        {
            try
            {
                _Connection.Open();

                query.ExecuteNonQuery();

                _Connection.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string GetExecuteDmlValue(SqlCommand query)
        {
            try
            {
                _Connection.Open();

                string value = query.ExecuteScalar().ToString();

                _Connection.Close();

                return value;
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public DataTable LoadData(SqlDataAdapter query)
        {
            try
            {
                DataTable data = new DataTable();
                _Connection.Open();
                query.Fill(data);
                _Connection.Close();
                return data;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        #endregion

        #region Foto

        public bool SavePhoto(int id, string destination)
        {

            SqlCommand command = new SqlCommand("update Personas set FotoPerfil=@foto where Id = @id", _Connection);

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@foto", destination);

            return ExecuteDml(command);
        }

        public int GetLastId()
        {
            int lastId = 0;

            _Connection.Open();

            SqlCommand command = new SqlCommand("select max(id) as Id from Medicos", _Connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                lastId = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
            }

            reader.Close();
            reader.Dispose();


            _Connection.Close();

            return lastId;

        }
        #endregion

        #region  getValidDelect

        public bool getValidDelectPaciente(int idPaciente)
        {
            SqlDataAdapter get_resultado = new SqlDataAdapter("select Estado_Resultado from Resultados_Laboratorio" +
                 " where Estado_Resultado=0 and idPaciente=" + idPaciente, _Connection);

            int valorLaboratorio = Convert.ToInt32(LoadData(get_resultado).Rows.Count);

            SqlDataAdapter get_cita = new SqlDataAdapter("select Estado_Cita from Citas" +
                 " where Estado_Cita=0 and idPaciente=" + idPaciente, _Connection);


            int valorCita = Convert.ToInt32(LoadData(get_cita).Rows.Count);


            if (valorLaboratorio > 0 || valorCita > 0)
            {
                return false;

            }

            return true;
        }

        public bool getValidDelectMedico(int idMedico)
        {
            SqlDataAdapter get_resultado = new SqlDataAdapter("select Estado_Resultado from Resultados_Laboratorio" +
                 " where Estado_Resultado=0 and idDoctor=" + idMedico, _Connection);

            int valorLaboratorio = Convert.ToInt32(LoadData(get_resultado).Rows.Count);

            SqlDataAdapter get_cita = new SqlDataAdapter("select Estado_Cita from Citas" +
                 " where Estado_Cita=0 and idDoctor=" + idMedico, _Connection);


            int valorCita = Convert.ToInt32(LoadData(get_cita).Rows.Count);


            if (valorLaboratorio > 0 || valorCita > 0)
            {
                return false;

            }

            return true;
        }

        public bool getValidDelectPrueba(int idPrueba)
        {
            SqlDataAdapter resultado = new SqlDataAdapter("select * from Resultados_Laboratorio" +
                " where idPrueva_Laboriatorio=" + idPrueba, _Connection);

            int cant = LoadData(resultado).Rows.Count;

            if (cant == 0)
            {
                return true;
            }

            return false;
        }

        public bool getValidDelectCitas(int index)
        {
            SqlDataAdapter citas = new SqlDataAdapter("select Estado_Cita from Citas" +
                " where id="+index, _Connection);

            int cant = LoadData(citas).Rows.Count;

            if (cant == 0)
            {
                return false;
            }

            return false;
        }

        #endregion
    }
}
