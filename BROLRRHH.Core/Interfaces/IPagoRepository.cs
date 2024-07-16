using BROLRRHH.Core.Requests.PagoRequest;
using BROLRRHH.Core.Responses.PagoResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Interfaces
{
    public interface IPagoRepository
    {
        Task<PagoGeneric_Response> InsertarSueldo(usp_InsertarSueldo_Request obj);
        Task<PagoGeneric_Response> ActualizarSueldo(usp_ActualizarSueldo_Request obj);
        Task<IEnumerable<usp_ListarRecibosEmpleado_Response>> ListarRecibosEmpleado(usp_ListarRecibosEmpleado_Request obj);
        Task<usp_ConsultarSueldoCod_Response> ConsultarSueldoCod(usp_ConsultarSueldoCod_Request obj);
    }
}
