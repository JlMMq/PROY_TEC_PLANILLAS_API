using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Responses.EmpleadoResponse
{
    public class usp_ConsultarEmpleado_response
    {
            public int codEmpleado { get; set; }
            public String numroDoc { get; set; }
            public String tipoDoc { get; set; }
            public String apellidos { get; set; }
            public String? nombres { get; set; }
            public DateTime? fecNacimiento { get; set; }
            public String? genero { get; set; }
            public String? correo { get; set; }
            public String? direccion { get; set; }
            public int? telefono { get; set; }
            public DateTime? fecIngreso { get; set; }

            public int? codCargo { get; set; }
            public int? codArea { get; set; }
            public int? codSede { get; set; }
            public int? codHorario { get; set; }

            public byte[]? foto { get; set; }
            public int? estado { get; set; }

    }
}
