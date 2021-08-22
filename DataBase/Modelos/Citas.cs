using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Modelos
{
    public class Citas
    {
        public int id { get; }
        public int idPaciente { get; set; }
        public int idDoctor { get; set; }
        public string FechaCita { get; set; }
        public string CausaCita { get; set; }
        public int EstadoCita { get; set; }

        public Citas(int idpaciente,int iddoctor,int estadocita,string fechacita,string causacita)
        {
            this.idPaciente = idpaciente;
            this.idDoctor = iddoctor;
            this.EstadoCita = estadocita;
            this.CausaCita = causacita;
            this.FechaCita = fechacita;
        }
    }
}
