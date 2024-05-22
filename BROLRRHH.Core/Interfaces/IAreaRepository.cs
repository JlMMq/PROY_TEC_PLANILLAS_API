using BROLRRHH.Core.Responses.AreaResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Interfaces
{
    public interface IAreaRepository
    {
        Task<List<usp_ListarArea_Response>> ListarArea();
    }
}
