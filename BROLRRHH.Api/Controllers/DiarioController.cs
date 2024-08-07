﻿using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.DiarioRequest;
using BROLRRHH.Core.Responses.DiarioResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BROLRRHH.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiarioController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DiarioController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost ("ConsultarDiario")]
        public async Task<IActionResult> ConsultarDiario (usp_ConsultarDiario_Request obj)
        {
            try
            {
                var res = await _unitOfWork.DiarioRepository.ConsultarDiario(obj);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPost("ConsultarDiarioFecEmpl")]
        public async Task<IActionResult> ConsultarDiarioFecEmpl(usp_ConsultarDiarioFecEmpl_Request obj)
        {
            try
            {
                var res = await _unitOfWork.DiarioRepository.ConsultarDiarioFecEmpl(obj);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("ListarDiario")]
        public async Task<IActionResult> ListarDiario()
        {
            try
            {
                var res = await _unitOfWork.DiarioRepository.ListarDiario();
                return Ok(res);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
