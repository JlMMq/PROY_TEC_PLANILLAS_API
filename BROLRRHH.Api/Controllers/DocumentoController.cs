using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.DocumentoRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BROLRRHH.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DocumentoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost("ConsultarDocumento")]
        public async Task<IActionResult> ConsultarDocumento(usp_ConsultarDocumento_Request obj)
        {
            try
            {
                var res = await _unitOfWork.DocumentoRepository.ConsultarDocumento(obj);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("ListarDocumentos")]
        public async Task<IActionResult> ListarDocumentos()
        {
            try
            {
                var res = await _unitOfWork.DocumentoRepository.ListarDocumentos();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
