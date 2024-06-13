using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.LoginRequest;
using BROLRRHH.Core.Responses.LoginResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BROLRRHH.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public LoginController (IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost("ValidarUsuario")]
        public async Task<IActionResult> ValidarUsuario (usp_ValidarUserSystem_Request request)
        {
            try
            {
                usp_ValidarUserSystem_Result res = await _unitOfWork.LoginRepository.ValidarUsuarioSistema(request);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return  BadRequest(ex.Message); 
            }
        }

        [HttpPost("ActualizarCorreo")]
        public async Task<IActionResult> ActualizarCorreo(usp_ActualizarCorreo_Request rq)
        {
            try
            {
                var res = await _unitOfWork.LoginRepository.ActualizarCorreo(rq);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("ActualizarPass")]
        public async Task<IActionResult> ActualizarPassword(usp_CambiarPassword_Request rq)
        {
            try
            {
                var res = await _unitOfWork.LoginRepository.CambiarPassword(rq);
                return Ok(res);
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);
            } 
        }
            
    }
}
