using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.PagoRequest;
using BROLRRHH.Core.Responses.PagoResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace BROLRRHH.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PagoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost("InsertarSueldo")]
        public async Task<IActionResult> InsertarSueldo(usp_InsertarSueldo_Request obj)
        {
            try
            {
                PagoGeneric_Response res = await _unitOfWork.PagoRepository.InsertarSueldo(obj);
                return Ok(res);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("ActualizarSueldo")]
        public async Task<IActionResult> ActualizarSueldo(usp_ActualizarSueldo_Request obj)
        {
            try
            {
                PagoGeneric_Response res = await _unitOfWork.PagoRepository.ActualizarSueldo(obj);
                return Ok(res);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("ListarRecibosEmpleado")]
        public async Task<IActionResult> ListarRecibosEmpleado(usp_ListarRecibosEmpleado_Request obj)
        {
            try
            {
                var res = await _unitOfWork.PagoRepository.ListarRecibosEmpleado(obj);
                return Ok(res);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("ConsultarSueldoCod")]
        public async Task<IActionResult> ConsultarSueldoCod(usp_ConsultarSueldoCod_Request obj)
        {
            try
            {
                var res = await _unitOfWork.PagoRepository.ConsultarSueldoCod(obj);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
