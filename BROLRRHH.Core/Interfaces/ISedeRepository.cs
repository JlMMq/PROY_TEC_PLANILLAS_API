using BROLRRHH.Core.Responses.SedeResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Interfaces
{
    public interface ISedeRepository
    {
        Task<List<usp_ListarSede_Response>> ListarSede();
    }
}
