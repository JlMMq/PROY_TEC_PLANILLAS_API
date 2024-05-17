using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.EmpleadoRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BROLRRHH.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmpleadoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost ("ConsultarEmpleado")]
        public async Task<IActionResult> ConsultarEmpleado (usp_ConsultarEmpleado_Request obj)
        {
            try
            {
                var res = await _unitOfWork.EmpleadoRepository.ConsultarEmpleado(obj);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("ConsultarEmpleadoCodDoc")]
        public async Task<IActionResult> ConsultarEmpleadoCodDoc(usp_ConsultarEmpleadoCodDoc_Request obj)
        {
            try
            {
                var res = await _unitOfWork.EmpleadoRepository.ConsultarEmpleadoCodDoc(obj);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ListarEmpleadosView")]
        public async Task<IActionResult> ListarEmpleadosView()
        {
            try
            {
                var res = await _unitOfWork.EmpleadoRepository.ListarEmpleadoView();
                return Ok(res);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
