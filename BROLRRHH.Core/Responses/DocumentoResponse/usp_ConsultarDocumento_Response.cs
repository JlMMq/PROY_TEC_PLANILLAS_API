﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Responses.DocumentoResponse
{
    public class usp_ConsultarDocumento_Response
    {
        public String? codDoc { get; set; }
        public String? descrCorta { get; set; }
        public String? descrLarga { get; set; }
        public int? longitud { get; set; }
    }
}
