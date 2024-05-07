using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Responses.LoginResponse
{
    public class usp_ValidarUserSystem_Result
    {
        public bool estadoTrans {  get; set; }
        public int codUser {  get; set; }
        public int permiso { get; set; }
    }
}
