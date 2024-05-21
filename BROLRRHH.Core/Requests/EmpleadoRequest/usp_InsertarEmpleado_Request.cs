using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Requests.EmpleadoRequest
{
    public class usp_InsertarEmpleado_Request
    {
        public string numroDoc { get; set; }
        public string tipoDoc { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public DateTime? fecNacimiento { get; set; }
        public string genero { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public int? telefono { get; set; }
        public DateTime? fecIngreso { get; set; }

        public int codCargo { get; set; }
        public int codArea { get; set; }
        public int codSede { get; set; }
        public int codHorario { get; set; }
        public byte[]? foto { get; set; }
        public string? usu_Reg { get; set; }
        public int? estado { get; set; }
    }
}
