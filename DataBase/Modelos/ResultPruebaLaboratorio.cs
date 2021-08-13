using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Modelos
{
    public class ResultPruebaLaboratorio
    {
        public int id { get; }
        public int idPaciente { get; set; }
        public int idCita { get; set; }
        public int idPruebaLabo { get; set; }
        public int idDoctor { get; set; }
        public string ResultadoPrueva { get; set; }
        public int EstadoResultado { get; set; }

        public ResultPruebaLaboratorio(int idpaciente,int idcita,int idprueba,int iddoctor,string resultado,int estado)
        {
            this.idPaciente = idpaciente;
            this.idCita = idcita;
            this.idPruebaLabo = idprueba;
            this.ResultadoPrueva = resultado;
            this.EstadoResultado = estado;
            this.idDoctor = iddoctor;
        }
    }
}
