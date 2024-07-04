using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Requests.SolicitudRequest
{
    public class usp_ListarSolicitudesView_Request
    {
        public int codSupervisor {  get; set; }
        public int codSolicitante { get; set; }
    }
}
