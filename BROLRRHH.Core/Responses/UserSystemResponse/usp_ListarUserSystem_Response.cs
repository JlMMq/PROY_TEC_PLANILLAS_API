using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Responses.UserSystemResponse
{
    public class usp_ListarUserSystem_Response
    {
        public int codUser {  get; set; }
        public string nomUser { get; set; }
        public string? correoUser { get; set; }
        public int permisoUser { get; set; }
        public string? str_nombres { get; set; }
        public string? str_apellidos { get; set; }
        public DateTime? fec_Reg { get; set; }
        public int estdUser { get; set; }   
    }
}
