using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Responses.HorarioResponse
{
    public class usp_ListarHorarios_Response
    {
        public int? codHorario { get; set; }
        public String? desHorario { get; set; }
        public TimeSpan? ingLUN { get; set; }
        public TimeSpan? salLUN { get; set; }
        public TimeSpan? ingMAR { get; set; }
        public TimeSpan? salMAR { get; set; }
        public TimeSpan? ingMIE { get; set; }
        public TimeSpan? salMIE { get; set; }
        public TimeSpan? ingJUE { get; set; }
        public TimeSpan? salJUE { get; set; }
        public TimeSpan? ingVIE { get; set; }
        public TimeSpan? salVIE { get; set; }
        public TimeSpan? ingSAB { get; set; }
        public TimeSpan? salSAB { get; set; }
        public TimeSpan? ingDOM { get; set; }
        public TimeSpan? salDOM { get; set; }
        public int? refriger { get; set; }
        public int? tolernc { get; set; }
        public int? diaDesc { get; set; }
    }
}
