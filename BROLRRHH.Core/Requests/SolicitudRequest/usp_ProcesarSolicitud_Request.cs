using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Requests.SolicitudRequest
{
    public class usp_ProcesarSolicitud_Request
    {
        public int codSolicitud {  get; set; }
        public int estado { get; set; }
        public string usuario { get; set; }
    }
}
