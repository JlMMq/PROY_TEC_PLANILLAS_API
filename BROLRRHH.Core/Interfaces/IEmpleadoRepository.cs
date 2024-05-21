using BROLRRHH.Core.Requests.EmpleadoRequest;
using BROLRRHH.Core.Responses.EmpleadoResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Interfaces
{
    public interface IEmpleadoRepository
    {
        Task<usp_ConsultarEmpleado_response> ConsultarEmpleado(usp_ConsultarEmpleado_Request obj);
        Task<usp_ConsultarEmpleado_response> ConsultarEmpleadoCodDoc(usp_ConsultarEmpleadoCodDoc_Request obj);
        Task<List<usp_ListarEmpleadoView_response>> ListarEmpleadoView();
        Task<bool> InsertarEmpleado(usp_InsertarEmpleado_Request obj);
        Task<bool> ActualizarEmpleado(usp_ActualizarEmpleado_Request obj);
        Task<bool> EliminarEmpleado(usp_EliminarEmpleado_Request obj);
    }
}
