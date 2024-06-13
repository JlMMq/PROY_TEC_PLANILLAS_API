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
        public string nomUser { get; set; }

        public string? str_nombres { get; set; }
        public string? str_apellidos { get; set; }
        public string? correoUser { get; set; }

        public int permiso { get; set; }
    }
}
