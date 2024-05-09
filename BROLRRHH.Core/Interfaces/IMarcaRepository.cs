using BROLRRHH.Core.Requests.MarcaRequest;
using BROLRRHH.Core.Responses.MarcaResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Interfaces
{
    public interface IMarcaRepository
    {
        Task<usp_InsertarMarca_Response> InsertarMarca(usp_InsertarMarca_Request obj);
    }
}
