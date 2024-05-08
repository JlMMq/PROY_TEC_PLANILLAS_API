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
    }
}
