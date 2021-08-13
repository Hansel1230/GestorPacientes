
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

        public bool LoginReader { get; set; }

        public RepositorioGestorPacientes(SqlConnection Connection)
        {
            _Connection = Connection;
        }

        #region login 

        public bool validLogin(string user,string contrasena)
        {
            Usuario usuario = new Usuario(user,contrasena);

            SqlCommand command = new SqlCommand("select Nombre_Usuario,Contrasena from Usuarios" +
                " where Nombre_Usuario=@nombre_user and Contrasena=@contrasena)", _Connection);

            command.Parameters.AddWithValue("@nombre_user", usuario.NombreUser);
            command.Parameters.AddWithValue("@contrasena", usuario.Contrasena);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                LoginReader = true;
            }
            else
            {
                LoginReader = false;
            }

            return ExecuteDml(command);
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
        

    }
}
