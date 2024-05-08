﻿using BROLRRHH.Core.Requests.DiarioRequest;
using BROLRRHH.Core.Responses.DiarioResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Interfaces
{
    public interface IDiarioRepository
    {
        Task<usp_ConsultarDiario_Response> ConsultarDiario(usp_ConsultarDiario_Request obj);
    }
}