using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Modelos
{
    public class PruebaLaboratorio
    {
        public int id { get; }
        public string Nombre { get; set; }

        public PruebaLaboratorio(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
