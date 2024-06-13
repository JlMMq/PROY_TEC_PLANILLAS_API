using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Requests.UserSystemRequest
{
    public class usp_UpdPermisosUserSystem_Request
    {
        public int codUser {  get; set; }
        public int permiso { get; set; }
        public int estado { get; set; }
    }
}
