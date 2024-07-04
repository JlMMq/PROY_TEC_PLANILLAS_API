using BROLRRHH.Core.Requests.SolicitudRequest;
using BROLRRHH.Core.Responses.SolicitudResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Interfaces
{
    public interface ISolicitudRepository
    {
        Task<usp_InsertarSolicitud_Response> InsertarSolicitud(usp_InsertarSolicitud_Request obj);
        Task<usp_ProcesarSolicitud_Response> ProcesarSolicitud(usp_ProcesarSolicitud_Request obj);
    }
}
