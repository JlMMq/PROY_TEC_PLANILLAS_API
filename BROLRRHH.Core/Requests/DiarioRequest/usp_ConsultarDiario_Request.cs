using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Requests.DiarioRequest
{
    public class usp_ConsultarDiario_Request
    {
        public int codigo {  get; set; }
    }
    public class usp_ConsultarDiarioFecEmpl_Request
    {
        public DateTime fecha { get; set; }
        public int empleado { get; set; }
    }
}
