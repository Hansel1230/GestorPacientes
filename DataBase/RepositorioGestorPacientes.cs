
using DataBase.Modelos;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataBase
{
    public class RepositorioGestorPacientes
    {
        private SqlConnection _Connection;

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
            while(reader.Read())
            {
                usuario.id = reader.IsDBNull(0)?0:reader.GetInt32(0);
                usuario.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                usuario.Apellido= reader.IsDBNull(2) ? "" : reader.GetString(2);
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

        public bool EditarUsuario(Usuario item,int idUsuario)
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

            command.Parameters.AddWithValue("@id",id);

            return ExecuteDml(command);
        }
        #endregion

        #region Mant.bbdd.Medicos

        //Medicos

        public bool AgregarMedico(Medico item)
        {
            SqlCommand command = new SqlCommand("insert into Medicos(Nombre,Apellido,Correo,Cedula,Foto) values (@nombre,@apellido,@correo,@cedula,@foto)", _Connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@foto", item.Foto);

            return ExecuteDml(command);
        }

        public bool EditarMedico(Medico item, int idMedico)
        {
            SqlCommand command = new SqlCommand("update Medicos set Nombre=@nombre,Apellido=@apellido,Correo=@correo," +
                "Cedula=@cedula,Foto=@foto where id=@id", _Connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
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
            command.Parameters.AddWithValue("@fecha_nacimiento", item.Telefono);
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
            SqlCommand command = new SqlCommand("insert into Pacientes(Nombre) values (@nombre)", _Connection);

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
        #endregion

        #region Mant.bbdd.Citas

        //Pruebas_Laboratorio

        public bool AgregarCita(Citas item)
        {
            SqlCommand command = new SqlCommand("insert into Citas(idPaciente,idDoctor,Fecha_Hora_Cita,Causa_Cita," +
                "Estado_Cita) values (@idpaciente,@idDoctor,@fecha_hora_cita,@causa_cita,@estado_cita)", _Connection);

            command.Parameters.AddWithValue("@idpaciente", item.idPaciente);
            command.Parameters.AddWithValue("@idDoctor", item.idDoctor);
            command.Parameters.AddWithValue("@fecha_hora_cita", item.FechaCita);
            command.Parameters.AddWithValue("@causa_cita", item.CausaCita);
            command.Parameters.AddWithValue("@estado_cita", item.EstadoCita);


            return ExecuteDml(command);
        }
        #endregion

        #region getData
        public DataTable GetAllUsuario()
        {
            //SqlDataAdapter query = new SqlDataAdapter("Select * from Usuarios", _Connection);
            SqlDataAdapter query = new SqlDataAdapter("select id,Nombre,Apellido,Correo,Nombre_Usuario," +
            "CASE WHEN Tipo_Usuario = 1 THEN 'Administrador' ELSE 'Usuario' END AS 'Tipo de Usuario' from Usuarios" , _Connection);

            return LoadData(query);
        }

        public DataTable GetAllMedico()
        {
            SqlDataAdapter query = new SqlDataAdapter("select Nombre,Apellido,Correo,Telefono,Cedula," +
                "Foto from Medicos", _Connection);

            return LoadData(query);
        }

        public DataTable GetAllPaciente()
        {
            SqlDataAdapter query = new SqlDataAdapter("select Nombre,Apellido,Telefono,Direccion,Cedula," +
                "Fecha_Nacimiento as 'Fecha de nacimiento'," +
                "Fumador,Alergia,Foto from Pacientes", _Connection);

            return LoadData(query);
        }

        public DataTable GetAllPrueba()
        {
            SqlDataAdapter query = new SqlDataAdapter("select Nombre from Pruebas_Laboratorio", _Connection);

            return LoadData(query);
        }

        public DataTable GetAllResultado()
        {
            //se requiere 'NombrePaciente','ApellidoPaciente','CedulaPaciente','NombrePruebalaboratorio'
            SqlDataAdapter query = new SqlDataAdapter("select idPaciente as 'Paciente',idCita as 'Cita'," +
                "idPrueba_Laboratorio as 'Prueba de laboratorio',idDoctor as 'Doctor'," +
                "Resultado_Prueba as 'Resultado de prueba',Estado_Resultado as 'Estado de prueba'" +
                "from Resultados_Laboratorio", _Connection);
              //+"inner join Pacientes on (id)", _Connection);

            return LoadData(query);
        }

        public DataTable GetAllCita()
        {
            SqlDataAdapter query = new SqlDataAdapter("select Nombre,Apellido,Correo,Nombre_Usuario,Contrasena," +
                "Tipo_Usuario from Usuarios", _Connection);

            return LoadData(query);
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

        public DataTable LoadData(SqlDataAdapter query)
        {
            try
            {
                DataTable data = new DataTable();
                _Connection.Open();
                query.Fill(data);
                _Connection.Close();
                return data;
            }catch (Exception e)
            {
                return null;
            }

        }
        #endregion

        #region Foto

        public bool SavePhoto(int id, string destination)
        {

            SqlCommand command = new SqlCommand("update Personas set FotoPerfil=@foto where Id = @id",_Connection);

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@foto", destination);

            return ExecuteDml(command);
        }

        public int GetLastId()
        {
            int lastId = 0;

            _Connection.Open();

            SqlCommand command = new SqlCommand("select max(Id) as Id from Personas", _Connection);

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
    }
}
