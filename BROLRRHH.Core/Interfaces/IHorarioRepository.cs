using BROLRRHH.Core.Requests.HorarioRequest;
using BROLRRHH.Core.Responses.HorarioResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Interfaces
{
    public interface IHorarioRepository
    {
        Task<usp_ConsultarHorario_Response> ConsultarHorario(usp_ConsultarHorario_Request obj);
    }
}
