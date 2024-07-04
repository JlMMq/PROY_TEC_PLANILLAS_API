using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.SolicitudRequest;
using BROLRRHH.Core.Responses.SolicitudResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BROLRRHH.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SolicitudController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("ListarSolicitudesSuperv")]
        public async Task<IActionResult> ListarSolicitudesSuperv()
        {
            try
            {
                //var res = await _unitOfWork.SedeRepository.ListarSede();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("InsertarSolicitud")]
        public async Task<IActionResult> InsertarSolicirtud(usp_InsertarSolicitud_Request obj)
        {
            try
            {
                usp_InsertarSolicitud_Response res = await _unitOfWork.SolicitudRepository.InsertarSolicitud(obj);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("ProcesarSolicitud")]
        public async Task<IActionResult> ProcesarSolicitud(usp_ProcesarSolicitud_Request obj)
        {
            try
            {
                usp_ProcesarSolicitud_Response res = await _unitOfWork.SolicitudRepository.ProcesarSolicitud(obj);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
