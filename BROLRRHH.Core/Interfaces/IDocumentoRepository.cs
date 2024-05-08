using BROLRRHH.Core.Requests.DocumentoRequest;
using BROLRRHH.Core.Responses.DocumentoResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Interfaces
{
    public interface IDocumentoRepository
    {
        Task<usp_ConsultarDocumento_Response> ConsultarDocumento(usp_ConsultarDocumento_Request obj);
    }
}
