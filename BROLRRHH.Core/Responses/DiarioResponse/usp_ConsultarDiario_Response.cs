using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Responses.DiarioResponse
{
    public class usp_ConsultarDiario_Response
    {
        public Int32 codDiar { get; set; }
        public DateTime? fecha { get; set; }
        public Int32? empleado { get; set; }
        public Int32? horario { get; set; }
        public TimeSpan? hIngreso { get; set; }
        public TimeSpan? hSalida { get; set; }
        public TimeSpan? hora1 { get; set; }
        public TimeSpan? hora2 { get; set; }
        public TimeSpan? hora3 { get; set; }
        public TimeSpan? hora4 { get; set; }
        public TimeSpan? ingrTard { get; set; }
        public TimeSpan? exeRefr { get; set; }
        public TimeSpan? exeJornd { get; set; }
        public String? observ { get; set; }
    //    public DateTime? fec_Reg { get; set; }
    //    public string? usu_Reg { get; set; }
    //    public DateTime? fec_UltMod { get; set; }
    //    public String? usu_UltMod { get; set; }
    }
}
