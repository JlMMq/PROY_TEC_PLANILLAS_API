using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.HorarioRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BROLRRHH.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorarioController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public HorarioController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost("ConsultarHorario")]
        public async Task<IActionResult> ConsultarHorario(usp_ConsultarHorario_Request obj)
        {
            try
            {
                var res = await _unitOfWork.HorarioRepository.ConsultarHorario(obj);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
