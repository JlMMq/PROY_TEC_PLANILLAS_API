using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Responses.EmpleadoResponse
{
    public class usp_ListarSoliEmpleadosSuperv_response
    {
        public int codEmpleado {  get; set; }
        public string apenom { get; set; }
        public string nomCargo { get; set; }
        public string nomArea { get; set; }
        public byte[]? foto { get; set; }
    }
}
