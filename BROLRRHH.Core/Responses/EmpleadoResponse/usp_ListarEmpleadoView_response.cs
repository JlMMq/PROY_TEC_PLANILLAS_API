using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Responses.EmpleadoResponse
{
    public class usp_ListarEmpleadoView_response
    {
        public int codEmpleado { get; set; }
        public string numroDoc { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public int estado { get; set; }
        public string nombreDocumento { get; set; }
        public string nombreCargo { get; set; }
        public string nombreArea { get; set; }
        public string nombreHorario { get; set; }
    }
}
