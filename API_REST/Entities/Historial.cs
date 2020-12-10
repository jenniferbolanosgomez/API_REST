using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST.Entities
{
    public class Historial
    {

        public int Id { get; set; }

        [Key]
        public string Documento { get; set; }

        public string NombrePaciente { get; set; }

        public DateTime FechaCita { get; set; }


        public string NombreDoctor { get; set; }

        public string Observacion { get; set; }

    }
}
