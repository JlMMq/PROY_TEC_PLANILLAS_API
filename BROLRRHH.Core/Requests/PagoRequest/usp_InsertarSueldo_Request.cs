﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Requests.PagoRequest
{
    public class usp_InsertarSueldo_Request
    {
        public int empleado {  get; set; }
        public float sueldo { get; set; }
        public int flag_essalud {  get; set; }
        public int flag_onp { get; set; }
        public int flag_afp { get; set; }
        public string usuario { get; set; }
    }
}
