using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Requests.SolicitudRequest
{
    public class usp_InsertarSolicitud_Request
    {
        public int codSolicitante { get; set; }
        public int codSupervisor { get; set; }
        public int tipoSolic { get; set; }
        public int tipoAsunto { get; set; }
        public string asunto { get; set; }
        public string? descrip { get; set; }
        public DateTime fechaIni { get; set; }
        public DateTime fechaFin {get;set;}
	    public DateTime horaSalida {  get; set; }
        public DateTime horaEntrada {  get; set; }
        
	    public byte[]? archivo { get; set; }
        public string? usuario { get; set; }
    }
}
