using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Responses.PagoResponse
{
    public class usp_ListarRecibosEmpleado_Response
    {
        public int codRecibo { get; set; }
        public int codEmpleado { get; set; }
        public string apenom {  get; set; }
        public DateTime fechaEmision {  get; set; }
        public string moneda { get; set; }
        public double sueldoBase { get; set; }
        public double descEssalud { get; set; }
        public double descOnp { get; set; }
        public double descAfp { get; set; }
        public double descFaltas { get; set;}
        public double sueldoTotal { get; set; }
    }
}
