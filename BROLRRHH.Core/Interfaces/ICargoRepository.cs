using BROLRRHH.Core.Responses.CargoResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Interfaces
{
    public interface ICargoRepository
    {
        Task<List<usp_ListarCargo_Response>> ListarCargo();
    }
}
