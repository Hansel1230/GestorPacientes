using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Modelos
{
    public class Usuario
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string NombreUser { get; set; }
        public string Contrasena { get; set; }
        public int TipoUser { get; set; }

        public Usuario()
        {

        }
        public Usuario(string nombre,string apellido,string correo,string nombreuser,string contrasena,int tipouser)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.NombreUser = nombreuser;
            this.Contrasena = contrasena;
            this.TipoUser = tipouser;
        }

        public Usuario(string nombreuser,string contrasena)
        {
            this.NombreUser = nombreuser;
            this.Contrasena = contrasena;
        }
    }

    
}
