using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Requests.EmpleadoRequest
{
    public class usp_ConsultarEmpleado_Request
    {
        public int codigo { get; set; }
    }
    public class usp_ConsultarEmpleadoCodDoc_Request
    {
        public int codigo { get; set; }
        public string numroDoc { get; set; }
    }
}
