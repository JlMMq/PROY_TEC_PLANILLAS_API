using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Responses.SolicitudResponse
{
    public class usp_ListarSolicitudesView_Response
    {
        public int codSolicitud { get; set; }
        public int codSupervisor { get; set; }
        public int codSolicitante { get; set; }
        public string nomape { get; set; }
        public byte[]? foto { get; set; }
        public int tipoSolic { get; set; }
        public string desc_solic { get; set; }
        public int tipoAsunto { get; set; }
        public string desc_asunto { get; set; }
        public string desc_content { get; set; }
        public int estado { get; set; }
        public string desc_estado { get; set; }
    }
}
