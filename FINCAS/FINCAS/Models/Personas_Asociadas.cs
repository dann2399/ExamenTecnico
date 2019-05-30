using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FINCAS.Models
{
    public class PersonasAsociadas
    {
        public int Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Parentesco { get; set; }
        public int Id_Finca { get; set; }
        public string Propietaria { get; set; }
    }
}
