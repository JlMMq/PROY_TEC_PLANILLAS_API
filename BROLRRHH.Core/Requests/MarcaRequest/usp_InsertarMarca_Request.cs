using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Requests.MarcaRequest
{
    public class usp_InsertarMarca_Request
    {
        public int empleado {  get; set; }
        public int horario { get; set; }
        public string? usu_Reg {  get; set; }
        public DateTime fecha { get; set; }
        public int tipo { get; set; }
    }
}
