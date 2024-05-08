using BROLRRHH.Core.Requests.MarcaRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Interfaces
{
    public interface IMarcaRepository
    {
        Task<bool> InsertarMarca(usp_InsertarMarca_Request obj);
    }
}
