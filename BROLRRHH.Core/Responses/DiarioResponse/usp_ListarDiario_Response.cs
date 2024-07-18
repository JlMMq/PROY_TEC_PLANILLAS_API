using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Responses.DiarioResponse
{
    public class usp_ListarDiario_Response
    {
        public int codDiar { get; set; }
        public DateTime fecha { get; set; }
        public int empleado { get; set; }
        public string apenom {  get; set; }
        public int horario { get; set; }
        public string desHorario { get; set; }
        public string? hora1 { get; set; }
        public string? hora2 { get; set; }
        public string? hora3 { get; set; }
        public string? hora4 { get; set; }
        public string? ingrTard { get; set; }
        public string? exeRefr { get; set; }
        public string? exeJornd { get; set; }
        public string? observ {  get; set; }
    }
}
