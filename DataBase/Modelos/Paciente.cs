using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Modelos
{
    public class Paciente
    {
        public int id { get; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public string Datebirth { get; set; }
        public bool Fumador { get; set; }
        public string Alergias { get; set; }
        public string Foto { get; set; }

        public Paciente(string nombre,string apellido,string telefono,string direccion,string cedula, string datebirth,bool fumador,string alergias,string foto)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Cedula = cedula;
            this.Datebirth = datebirth;
            this.Fumador = fumador;
            this.Alergias = alergias;
            this.Foto = foto;
        }

    }
}
