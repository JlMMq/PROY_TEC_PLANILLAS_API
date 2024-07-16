using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Responses.PagoResponse
{
    public class usp_ConsultarSueldoCod_Response
    {
        public int codSueldo {  get; set; }
        public int codEmpleado { get; set; }
        public double sueldo { get; set; }
        public int essalud {  get; set; }
        public int afil_onp { get; set; }
        public int afil_afp { get; set; }

    }
}
