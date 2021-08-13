using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Modelos
{
    public class Medico
    {
        public int id { get; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Foto { get; set; }

        public Medico(string nombre, string apellido, string correo, string telefono,string cedula,string foto)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.Cedula = cedula;
            this.Telefono = telefono;
            this.Foto = foto;
        }
    }
}
