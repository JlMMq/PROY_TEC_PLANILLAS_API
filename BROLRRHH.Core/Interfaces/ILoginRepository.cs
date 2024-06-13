using BROLRRHH.Core.Requests.LoginRequest;
using BROLRRHH.Core.Requests.UserSystemRequest;
using BROLRRHH.Core.Responses.LoginResponse;
using BROLRRHH.Core.Responses.UserSystemResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Interfaces
{
    public interface ILoginRepository
    {
        Task<usp_ValidarUserSystem_Result> ValidarUsuarioSistema(usp_ValidarUserSystem_Request obj);
        Task<bool> ActualizarCorreo(usp_ActualizarCorreo_Request obj);
        Task<bool> CambiarPassword(usp_CambiarPassword_Request obj);
        Task<List<usp_ListarUserSystem_Response>> ListarUsuarios();
        Task<bool> ActualizarPermisosUser(usp_UpdPermisosUserSystem_Request obj);
    }
}
