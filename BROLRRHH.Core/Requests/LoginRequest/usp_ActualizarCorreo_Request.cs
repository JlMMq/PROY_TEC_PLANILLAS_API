using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Requests.LoginRequest
{
    public class usp_ActualizarCorreo_Request
    {
        public int codUser { get; set; }
        public string correo { get; set; }
    }
}
