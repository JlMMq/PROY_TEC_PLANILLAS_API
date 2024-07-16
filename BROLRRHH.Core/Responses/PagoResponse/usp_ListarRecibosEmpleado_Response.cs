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
        public float sueldoBase { get; set; }
        public float descEssalud { get; set; }
        public float descOnp { get; set; }
        public float descAfp { get; set; }
        public float descFaltas { get; set;}
        public float sueldoTotal { get; set; }
    }
}
