using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.MarcaRequest;
using BROLRRHH.Core.Responses.MarcaResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace BROLRRHH.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MarcaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost("InsertarMarca")]
        public async Task<IActionResult> InsertarMarca(usp_InsertarMarca_Request obj)
        {
            try
            {
                usp_InsertarMarca_Response  res = await _unitOfWork.MarcaRepository.InsertarMarca(obj);
                return Ok(res);
            }catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
