using BROLRRHH.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BROLRRHH.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SystemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("IsAlive")]
        public async Task<IActionResult> IsAlive()
        {
            return Ok("Si");
        }
    }
}
